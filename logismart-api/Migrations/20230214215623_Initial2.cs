using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace logismartapi.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operatori_Mansioni_MansioneId",
                table: "Operatori");

            migrationBuilder.DropTable(
                name: "AttrezzatureDiLavoro");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "AreeMagazzino");

            migrationBuilder.DropIndex(
                name: "IX_Operatori_MansioneId",
                table: "Operatori");

            migrationBuilder.DropColumn(
                name: "MansioneId",
                table: "Operatori");

            migrationBuilder.AlterColumn<string>(
                name: "PartitaIva",
                table: "Aziende",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodiceUnivoco",
                table: "Aziende",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MansioneId",
                table: "Operatori",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartitaIva",
                table: "Aziende",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "CodiceUnivoco",
                table: "Aziende",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AreeMagazzino",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroContatto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreeMagazzino", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mansioni",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaMagazzinoId = table.Column<long>(type: "bigint", nullable: false),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFinePrevisto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataInizioPrevisto = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AttrezzatureDiLavoro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaMagazzinoId = table.Column<long>(type: "bigint", nullable: false),
                    OperatoreId = table.Column<long>(type: "bigint", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    MansioneId = table.Column<long>(type: "bigint", nullable: true),
                    NomeAttrezzatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttrezzatureDiLavoro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttrezzatureDiLavoro_AreeMagazzino_AreaMagazzinoId",
                        column: x => x.AreaMagazzinoId,
                        principalTable: "AreeMagazzino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttrezzatureDiLavoro_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttrezzatureDiLavoro_Operatori_OperatoreId",
                        column: x => x.OperatoreId,
                        principalTable: "Operatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operatori_MansioneId",
                table: "Operatori",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_AttrezzatureDiLavoro_AreaMagazzinoId",
                table: "AttrezzatureDiLavoro",
                column: "AreaMagazzinoId");

            migrationBuilder.CreateIndex(
                name: "IX_AttrezzatureDiLavoro_MansioneId",
                table: "AttrezzatureDiLavoro",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_AttrezzatureDiLavoro_OperatoreId",
                table: "AttrezzatureDiLavoro",
                column: "OperatoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Mansioni_AreaMagazzinoId",
                table: "Mansioni",
                column: "AreaMagazzinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operatori_Mansioni_MansioneId",
                table: "Operatori",
                column: "MansioneId",
                principalTable: "Mansioni",
                principalColumn: "Id");
        }
    }
}
