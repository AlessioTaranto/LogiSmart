using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogiSmart.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initia2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttrezzaturaDiLavoro");

            migrationBuilder.CreateTable(
                name: "Attrezzature",
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
                    table.PrimaryKey("PK_Attrezzature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attrezzature_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attrezzature_MansioneId",
                table: "Attrezzature",
                column: "MansioneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attrezzature");

            migrationBuilder.CreateTable(
                name: "AttrezzaturaDiLavoro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MansioneId = table.Column<long>(type: "bigint", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    NomeAttrezzatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_AttrezzaturaDiLavoro_MansioneId",
                table: "AttrezzaturaDiLavoro",
                column: "MansioneId");
        }
    }
}
