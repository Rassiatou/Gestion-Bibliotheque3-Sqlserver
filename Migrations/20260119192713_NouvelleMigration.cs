using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3_BD.Migrations
{
    /// <inheritdoc />
    public partial class NouvelleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participations_ActiviteId",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "Poste",
                table: "Employes",
                newName: "Role");

            migrationBuilder.AddColumn<bool>(
                name: "Actif",
                table: "Usagers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Usagers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeUsager",
                table: "Usagers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Presence",
                table: "Participations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_ActiviteId_UsagerId",
                table: "Participations",
                columns: new[] { "ActiviteId", "UsagerId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participations_ActiviteId_UsagerId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Actif",
                table: "Usagers");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Usagers");

            migrationBuilder.DropColumn(
                name: "TypeUsager",
                table: "Usagers");

            migrationBuilder.DropColumn(
                name: "Presence",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Employes",
                newName: "Poste");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_ActiviteId",
                table: "Participations",
                column: "ActiviteId");
        }
    }
}
