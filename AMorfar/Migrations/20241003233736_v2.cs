using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMorfar.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaPersona_Comanda_comandasid",
                table: "ComandaPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_ComandaPersona_Personas_personasid",
                table: "ComandaPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Comanda_Comandaid",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Producto",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Producto",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Comandaid",
                table: "Producto",
                newName: "ComandaID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Producto",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_Comandaid",
                table: "Producto",
                newName: "IX_Producto_ComandaID");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Personas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "personasid",
                table: "ComandaPersona",
                newName: "PersonasID");

            migrationBuilder.RenameColumn(
                name: "comandasid",
                table: "ComandaPersona",
                newName: "ComandasID");

            migrationBuilder.RenameIndex(
                name: "IX_ComandaPersona_personasid",
                table: "ComandaPersona",
                newName: "IX_ComandaPersona_PersonasID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Comanda",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaPersona_Comanda_ComandasID",
                table: "ComandaPersona",
                column: "ComandasID",
                principalTable: "Comanda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaPersona_Personas_PersonasID",
                table: "ComandaPersona",
                column: "PersonasID",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Comanda_ComandaID",
                table: "Producto",
                column: "ComandaID",
                principalTable: "Comanda",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaPersona_Comanda_ComandasID",
                table: "ComandaPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_ComandaPersona_Personas_PersonasID",
                table: "ComandaPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Comanda_ComandaID",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Producto",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Producto",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "ComandaID",
                table: "Producto",
                newName: "Comandaid");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Producto",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_ComandaID",
                table: "Producto",
                newName: "IX_Producto_Comandaid");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Personas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Personas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PersonasID",
                table: "ComandaPersona",
                newName: "personasid");

            migrationBuilder.RenameColumn(
                name: "ComandasID",
                table: "ComandaPersona",
                newName: "comandasid");

            migrationBuilder.RenameIndex(
                name: "IX_ComandaPersona_PersonasID",
                table: "ComandaPersona",
                newName: "IX_ComandaPersona_personasid");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Comanda",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaPersona_Comanda_comandasid",
                table: "ComandaPersona",
                column: "comandasid",
                principalTable: "Comanda",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaPersona_Personas_personasid",
                table: "ComandaPersona",
                column: "personasid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Comanda_Comandaid",
                table: "Producto",
                column: "Comandaid",
                principalTable: "Comanda",
                principalColumn: "id");
        }
    }
}
