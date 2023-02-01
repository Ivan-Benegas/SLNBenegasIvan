using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    Ingredientes = table.Column<string>(nullable: false),
                    Instrucciones = table.Column<string>(nullable: false),
                    AutorNombre = table.Column<string>(nullable: false),
                    AutorApellido = table.Column<string>(nullable: false),
                    Edad = table.Column<string>(nullable: false),
                    AutorEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
