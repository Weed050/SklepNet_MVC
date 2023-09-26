using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepNet_MVC.Migrations
{
    /// <inheritdoc />
    public partial class initializeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktualnosci",
                columns: table => new
                {
                    IdAktualnosc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktualnosci", x => x.IdAktualnosc);
                });

            migrationBuilder.CreateTable(
                name: "Towar",
                columns: table => new
                {
                    IdTowar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIPtowar = table.Column<bool>(type: "bit", nullable: false),
                    towarPromocyjny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towar", x => x.IdTowar);
                });

            migrationBuilder.CreateTable(
                name: "StanyMagazynowe",
                columns: table => new
                {
                    IdStanMagazynowy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TowarIdTowar = table.Column<int>(type: "int", nullable: false),
                    IdTowar = table.Column<int>(type: "int", nullable: false),
                    Stan = table.Column<int>(type: "int", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanyMagazynowe", x => x.IdStanMagazynowy);
                    table.ForeignKey(
                        name: "FK_StanyMagazynowe_Towar_TowarIdTowar",
                        column: x => x.TowarIdTowar,
                        principalTable: "Towar",
                        principalColumn: "IdTowar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TowarZdjecie",
                columns: table => new
                {
                    IdTowarZdjecie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TowarIdTowar = table.Column<int>(type: "int", nullable: false),
                    IdTowar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowarZdjecie", x => x.IdTowarZdjecie);
                    table.ForeignKey(
                        name: "FK_TowarZdjecie_Towar_TowarIdTowar",
                        column: x => x.TowarIdTowar,
                        principalTable: "Towar",
                        principalColumn: "IdTowar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StanyMagazynowe_TowarIdTowar",
                table: "StanyMagazynowe",
                column: "TowarIdTowar");

            migrationBuilder.CreateIndex(
                name: "IX_TowarZdjecie_TowarIdTowar",
                table: "TowarZdjecie",
                column: "TowarIdTowar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktualnosci");

            migrationBuilder.DropTable(
                name: "StanyMagazynowe");

            migrationBuilder.DropTable(
                name: "TowarZdjecie");

            migrationBuilder.DropTable(
                name: "Towar");
        }
    }
}
