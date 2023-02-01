using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class cambio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Receta");

            migrationBuilder.AddColumn<string>(
                name: "AutorEdad",
                table: "Receta",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutorEdad",
                table: "Receta");

            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "Receta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
