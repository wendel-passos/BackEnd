using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _07ExemploProjetoRH.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFuncionarioLogWithUniqueId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "FuncionariosLog",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "FuncionariosLog");
        }
    }
}
