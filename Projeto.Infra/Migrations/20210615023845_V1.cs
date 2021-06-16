using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.infra.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divida",
                columns: table => new
                {
                    IdTitulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NmDevedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrDevedor = table.Column<int>(type: "int", nullable: false),
                    Juros = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Multa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NrParcelas = table.Column<int>(type: "int", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VlParcela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divida", x => x.IdTitulo);
                });

            migrationBuilder.CreateTable(
                name: "Parcelas",
                columns: table => new
                {
                    IdParcela = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrParcelas = table.Column<int>(type: "int", nullable: false),
                    Ativos = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelas", x => x.IdParcela);
                });

            migrationBuilder.CreateTable(
                name: "TitulosAtrasos",
                columns: table => new
                {
                    IdAtraso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrTitulo = table.Column<int>(type: "int", nullable: false),
                    NmDevedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtdeParc = table.Column<int>(type: "int", nullable: false),
                    VlParc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiaAtraso = table.Column<int>(type: "int", nullable: false),
                    VlAtrsado = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitulosAtrasos", x => x.IdAtraso);
                });

            migrationBuilder.CreateTable(
                name: "DividaParcelas",
                columns: table => new
                {
                    DividasIdTitulo = table.Column<int>(type: "int", nullable: false),
                    ParcelasIdParcela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividaParcelas", x => new { x.DividasIdTitulo, x.ParcelasIdParcela });
                    table.ForeignKey(
                        name: "FK_DividaParcelas_Divida_DividasIdTitulo",
                        column: x => x.DividasIdTitulo,
                        principalTable: "Divida",
                        principalColumn: "IdTitulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DividaParcelas_Parcelas_ParcelasIdParcela",
                        column: x => x.ParcelasIdParcela,
                        principalTable: "Parcelas",
                        principalColumn: "IdParcela",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DividaParcelas_ParcelasIdParcela",
                table: "DividaParcelas",
                column: "ParcelasIdParcela");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DividaParcelas");

            migrationBuilder.DropTable(
                name: "TitulosAtrasos");

            migrationBuilder.DropTable(
                name: "Divida");

            migrationBuilder.DropTable(
                name: "Parcelas");
        }
    }
}
