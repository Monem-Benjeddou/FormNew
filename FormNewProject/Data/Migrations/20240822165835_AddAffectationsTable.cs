using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormNewProject.Migrations
{
    /// <inheritdoc />
    public partial class AddAffectationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defauts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Opn_Id = table.Column<int>(type: "int", nullable: false),
                    TRet_Id = table.Column<int>(type: "int", nullable: false),
                    Defauls = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defauts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reclamations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_Paquet = table.Column<int>(type: "int", nullable: false),
                    Opn_Id = table.Column<int>(type: "int", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operatrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chaine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReclamationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ControleType = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Affectations_Reclamations_ReclamationId",
                        column: x => x.ReclamationId,
                        principalTable: "Reclamations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Defauts",
                columns: new[] { "Id", "Defauls", "Opn_Id", "TRet_Id" },
                values: new object[] { new Guid("cb663965-79bc-416d-887c-bb179b217e26"), "Echappée de couture autre que glaçage : ", 1058, 47 });

            migrationBuilder.InsertData(
                table: "Reclamations",
                columns: new[] { "Id", "Chaine", "Num_Paquet", "OF", "Operation", "Operatrice", "Opn_Id" },
                values: new object[,]
                {
                    { new Guid("78610462-3bab-4cf2-83ff-489f31e80671"), "GHNP", 28, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("86aa310e-a6df-46db-9fe6-27a35d86e95c"), "GHNP", 28, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("aeed1f2d-03e6-4232-be6d-3c3c0fe0eafe"), "GHNP", 75, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("b28c00bb-811c-41da-8e07-db16a6ec1626"), "SG 4", 26, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("c671b314-47f9-4e4f-aeac-a46d35c9cf4d"), "SG 4", 19, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_ReclamationId",
                table: "Affectations",
                column: "ReclamationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Defauts");

            migrationBuilder.DropTable(
                name: "Reclamations");
        }
    }
}
