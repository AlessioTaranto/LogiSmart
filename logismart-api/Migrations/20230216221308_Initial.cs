using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogiSmart.Api.Migrations
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
                name: "AreeMagazzino",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagazzinoId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    NumeroContatto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreeMagazzino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreeMagazzino_Magazzini_MagazzinoId",
                        column: x => x.MagazzinoId,
                        principalTable: "Magazzini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Pec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Mansioni",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaMagazzinoId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataInizioPrevisto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFinePrevisto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MagazzinoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mansioni_AreeMagazzino_AreaMagazzinoId",
                        column: x => x.AreaMagazzinoId,
                        principalTable: "AreeMagazzino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mansioni_Magazzini_MagazzinoId",
                        column: x => x.MagazzinoId,
                        principalTable: "Magazzini",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AttrezzaturaDiLavoro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    NomeAttrezzatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MansioneId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttrezzaturaDiLavoro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttrezzaturaDiLavoro_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Operatori",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AziendaId = table.Column<long>(type: "bigint", nullable: false),
                    MansioneId = table.Column<long>(type: "bigint", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDiNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sesso = table.Column<int>(type: "int", nullable: false),
                    LuogoDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndirizzoDiDomicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodiceFiscale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroContatto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    CodiceOperatore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazzinoId = table.Column<long>(type: "bigint", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Operatori_Magazzini_MagazzinoId",
                        column: x => x.MagazzinoId,
                        principalTable: "Magazzini",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Operatori_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreeMagazzino_MagazzinoId",
                table: "AreeMagazzino",
                column: "MagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_AttrezzaturaDiLavoro_MansioneId",
                table: "AttrezzaturaDiLavoro",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Aziende_MagazzinoId",
                table: "Aziende",
                column: "MagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mansioni_AreaMagazzinoId",
                table: "Mansioni",
                column: "AreaMagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mansioni_MagazzinoId",
                table: "Mansioni",
                column: "MagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Operatori_AziendaId",
                table: "Operatori",
                column: "AziendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Operatori_MagazzinoId",
                table: "Operatori",
                column: "MagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Operatori_MansioneId",
                table: "Operatori",
                column: "MansioneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttrezzaturaDiLavoro");

            migrationBuilder.DropTable(
                name: "Operatori");

            migrationBuilder.DropTable(
                name: "Aziende");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "AreeMagazzino");

            migrationBuilder.DropTable(
                name: "Magazzini");
        }
    }
}
