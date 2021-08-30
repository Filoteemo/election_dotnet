using Microsoft.EntityFrameworkCore.Migrations;

namespace Valgapplikasjon.Migrations
{
    public partial class Kandidat_Stemme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KandidatStemmer",
                columns: table => new
                {
                    KandidatStemmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KandidatId = table.Column<int>(type: "int", nullable: false),
                    VoteCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KandidatStemmer", x => x.KandidatStemmeId);
                    table.ForeignKey(
                        name: "FK_KandidatStemmer_Kandidat_KandidatId",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "KandidatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KandidatStemmer_KandidatId",
                table: "KandidatStemmer",
                column: "KandidatId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KandidatStemmer");
        }
    }
}
