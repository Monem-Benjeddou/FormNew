using FormNewProject.Data;
using FormNewProject.Data.Entities;

namespace FormNewProject.Data.Entities
{
    public class Affectation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public ApplicationUser User { get; set; }
        public string UserId { get; set; } = string.Empty;
        public Reclamation Reclamation { get; set; }
        public ControleType ControleType { get; set; }
        public int Priority { get; set; }
    }
    public enum ControleType
    {
        Fini,
        Semi_Fini
    }
}
