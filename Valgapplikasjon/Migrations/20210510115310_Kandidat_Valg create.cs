using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Valgapplikasjon.Migrations
{
    public partial class Kandidat_Valgcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kandidat",
                columns: table => new
                {
                    KandidatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ValgId = table.Column<int>(type: "int", nullable: false),
                    Ansettelse = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Fakultet = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Institutt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Campus = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kandidat", x => x.KandidatId);
                    table.ForeignKey(
                        name: "FK_Kandidat_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Valg",
                columns: table => new
                {
                    ValgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittel = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StartNominering = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SluttNominering = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartAvstemming = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SluttAvstemming = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kontrollert = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valg", x => x.ValgId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kandidat_Id",
                table: "Kandidat",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kandidat");

            migrationBuilder.DropTable(
                name: "Valg");
        }
    }
}
