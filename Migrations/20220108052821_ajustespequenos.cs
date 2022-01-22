using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class ajustespequenos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Participante",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "containterna",
                table: "Participante",
                newName: "Containterna");

            migrationBuilder.RenameColumn(
                name: "conta",
                table: "Participante",
                newName: "Conta");

            migrationBuilder.RenameColumn(
                name: "cnpj",
                table: "Participante",
                newName: "Cnpj");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Participante",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Containterna",
                table: "Participante",
                newName: "containterna");

            migrationBuilder.RenameColumn(
                name: "Conta",
                table: "Participante",
                newName: "conta");

            migrationBuilder.RenameColumn(
                name: "Cnpj",
                table: "Participante",
                newName: "cnpj");
        }
    }
}
