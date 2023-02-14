using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace logismartapi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazzini",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazzini", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aziende",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagazzinoId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroContatto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartitaIva = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CodiceUnivoco = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Pec = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aziende", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aziende_Magazzini_MagazzinoId",
                        column: x => x.MagazzinoId,
                        principalTable: "Magazzini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operatori",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AziendaId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDiNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sesso = table.Column<int>(type: "int", nullable: false),
                    LuogoDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndirizzoDiDomicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodiceFiscale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroContatto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodiceOperatore = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operatori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operatori_Aziende_AziendaId",
                        column: x => x.AziendaId,
                        principalTable: "Aziende",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aziende_MagazzinoId",
                table: "Aziende",
                column: "MagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Operatori_AziendaId",
                table: "Operatori",
                column: "AziendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operatori");

            migrationBuilder.DropTable(
                name: "Aziende");

            migrationBuilder.DropTable(
                name: "Magazzini");
        }
    }
}
