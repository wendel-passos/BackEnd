using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaFederalImport.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CnpjBasico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificadorSocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeSocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnpjCpfSocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualificacaoSocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEntradaSociedade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpfRepresentanteLegal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeRepresentante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualificacaoRepresentante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaixaEtaria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socios");
        }
    }
}
