using System.Reflection;
using FormNewProject.Data.Entities;
using FormNewProject.Data.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FormNewProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Affectation> Affectations { get; set; }
        public DbSet<Defaut> Defauts { get; set; }
        public DbSet<Reclamation> Reclamations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*var currentDirectory = Directory.GetCurrentDirectory();
            var reclamations = SeedReclamationsFromCsv($"{currentDirectory}/Data/SeedData/reclamation.csv");
            modelBuilder.Entity<Reclamation>().HasData(reclamations);

            var defaults = SeedDefautsFromCsv($"{currentDirectory}/Data/SeedData/defaults.csv");
            modelBuilder.Entity<Defaut>().HasData(defaults);*/

            SeedRolesAndAdminUser(modelBuilder);
        }

        private List<Reclamation> SeedReclamationsFromCsv(string csvFilePath)
        {
            return ReclamationsToSeed.SeedReclamationsFromCsv(csvFilePath);
        }

        private List<Defaut> SeedDefautsFromCsv(string csvFilePath)
        {
            return DefautsToSeed.SeedDefaultsFromCsv(csvFilePath);
        }

        private void SeedRolesAndAdminUser(ModelBuilder modelBuilder)
        {
            string[] roleNames = { "Admin", "Responsable", "Controleuse", "Chef chaine" };
            var roleIds = new Dictionary<string, string>
            {
                { "Admin", Guid.NewGuid().ToString() },
                { "Responsable", Guid.NewGuid().ToString() },
                { "Controleuse", Guid.NewGuid().ToString() },
                { "Chef chaine", Guid.NewGuid().ToString() }
            };

            foreach (var roleName in roleNames)
            {
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = roleIds[roleName],
                    Name = roleName,
                    NormalizedName = roleName.ToUpper()
                });
            }

            var adminPassword = "Admin123!";
            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(), // Manually assign an ID for the admin user
                UserName = "Admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, adminPassword);

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Assign the "Admin" role to the admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminUser.Id,
                RoleId = roleIds["Admin"] // Use the correct role ID here
            });
        }
    }
}
