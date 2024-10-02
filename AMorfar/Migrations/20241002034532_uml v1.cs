using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMorfar.Migrations
{
    /// <inheritdoc />
    public partial class umlv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Personas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Personas",
                newName: "apellido");

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ComandaPersona",
                columns: table => new
                {
                    comandasid = table.Column<int>(type: "int", nullable: false),
                    personasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaPersona", x => new { x.comandasid, x.personasid });
                    table.ForeignKey(
                        name: "FK_ComandaPersona_Comanda_comandasid",
                        column: x => x.comandasid,
                        principalTable: "Comanda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaPersona_Personas_personasid",
                        column: x => x.personasid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    Comandaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Producto_Comanda_Comandaid",
                        column: x => x.Comandaid,
                        principalTable: "Comanda",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComandaPersona_personasid",
                table: "ComandaPersona",
                column: "personasid");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Comandaid",
                table: "Producto",
                column: "Comandaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaPersona");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Personas",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Personas",
                newName: "FirstName");
        }
    }
}
