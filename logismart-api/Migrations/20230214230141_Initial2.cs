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
            migrationBuilder.AddColumn<bool>(
                name: "Attivo",
                table: "Operatori",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Attivo",
                table: "Aziende",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_AreeMagazzino_MagazzinoId",
                table: "AreeMagazzino",
                column: "MagazzinoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreeMagazzino");

            migrationBuilder.DropColumn(
                name: "Attivo",
                table: "Operatori");

            migrationBuilder.DropColumn(
                name: "Attivo",
                table: "Aziende");
        }
    }
}
