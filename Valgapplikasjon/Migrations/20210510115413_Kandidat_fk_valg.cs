using Microsoft.EntityFrameworkCore.Migrations;

namespace Valgapplikasjon.Migrations
{
    public partial class Kandidat_fk_valg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat",
                column: "ValgId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kandidat_Valg_ValgId",
                table: "Kandidat",
                column: "ValgId",
                principalTable: "Valg",
                principalColumn: "ValgId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kandidat_Valg_ValgId",
                table: "Kandidat");

            migrationBuilder.DropIndex(
                name: "IX_Kandidat_ValgId",
                table: "Kandidat");
        }
    }
}
