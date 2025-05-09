using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _07ExemploProjetoRH.Migrations
{
    /// <inheritdoc />
    public partial class AddFuncionarioIdRelationshipToFuncionarioLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FuncionariosLog_FuncionarioId",
                table: "FuncionariosLog",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuncionariosLog_Funcionarios_FuncionarioId",
                table: "FuncionariosLog",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuncionariosLog_Funcionarios_FuncionarioId",
                table: "FuncionariosLog");

            migrationBuilder.DropIndex(
                name: "IX_FuncionariosLog_FuncionarioId",
                table: "FuncionariosLog");
        }
    }
}
