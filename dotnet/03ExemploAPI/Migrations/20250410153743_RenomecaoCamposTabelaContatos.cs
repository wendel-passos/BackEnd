using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03ExemploAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenomecaoCamposTabelaContatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Contatos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contatos",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Contatos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contatos",
                newName: "id");
        }
    }
}
