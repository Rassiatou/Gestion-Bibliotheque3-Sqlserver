using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3_BD.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEmailFromUsager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usagers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usagers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
