using Microsoft.EntityFrameworkCore.Migrations;

namespace Valgapplikasjon.Migrations
{
    public partial class Valgupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat");

            migrationBuilder.CreateIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat",
                column: "ValgId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat");

            migrationBuilder.CreateIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat",
                column: "ValgId",
                unique: true);
        }
    }
}
