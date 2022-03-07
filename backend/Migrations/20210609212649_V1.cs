using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zgrada",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SifraZgrade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zgrada", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Predlog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrZa = table.Column<int>(type: "int", nullable: false),
                    BrProtiv = table.Column<int>(type: "int", nullable: false),
                    DatumObjave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predlog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Predlog_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sastanak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Povod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrZainteresovanih = table.Column<int>(type: "int", nullable: false),
                    BrNezainteresovasnih = table.Column<int>(type: "int", nullable: false),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sastanak", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sastanak_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrStana = table.Column<int>(type: "int", nullable: false),
                    IznosDugovanja = table.Column<int>(type: "int", nullable: false),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stan_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mesec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godina = table.Column<int>(type: "int", nullable: false),
                    DatumPlacanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Iznos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Racun_Stan_StanRefID",
                        column: x => x.StanRefID,
                        principalTable: "Stan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stanar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrStana = table.Column<int>(type: "int", nullable: false),
                    BrSprata = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmbg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanRefID = table.Column<int>(type: "int", nullable: true),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true),
                    NezainteresovaniStanari = table.Column<int>(type: "int", nullable: true),
                    StanariProtiv = table.Column<int>(type: "int", nullable: true),
                    StanariZa = table.Column<int>(type: "int", nullable: true),
                    ZainteresovaniStanari = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stanar_Predlog_StanariProtiv",
                        column: x => x.StanariProtiv,
                        principalTable: "Predlog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Stanar_Predlog_StanariZa",
                        column: x => x.StanariZa,
                        principalTable: "Predlog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Stanar_Sastanak_NezainteresovaniStanari",
                        column: x => x.NezainteresovaniStanari,
                        principalTable: "Sastanak",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stanar_Sastanak_ZainteresovaniStanari",
                        column: x => x.ZainteresovaniStanari,
                        principalTable: "Sastanak",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stanar_Stan_StanRefID",
                        column: x => x.StanRefID,
                        principalTable: "Stan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stanar_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavestenje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: true),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavestenje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Obavestenje_Stanar_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Stanar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obavestenje_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: true),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poruka_Stanar_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Stanar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poruka_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkaOglasneTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: true),
                    ZgradaRefID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaOglasneTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StavkaOglasneTable_Stanar_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Stanar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkaOglasneTable_Zgrada_ZgradaRefID",
                        column: x => x.ZgradaRefID,
                        principalTable: "Zgrada",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Obavestenje_AutorID",
                table: "Obavestenje",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavestenje_ZgradaRefID",
                table: "Obavestenje",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_AutorID",
                table: "Poruka",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_ZgradaRefID",
                table: "Poruka",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Predlog_ZgradaRefID",
                table: "Predlog",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_StanRefID",
                table: "Racun",
                column: "StanRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Sastanak_ZgradaRefID",
                table: "Sastanak",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Stan_ZgradaRefID",
                table: "Stan",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_Email",
                table: "Stanar",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_NezainteresovaniStanari",
                table: "Stanar",
                column: "NezainteresovaniStanari");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_StanariProtiv",
                table: "Stanar",
                column: "StanariProtiv");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_StanariZa",
                table: "Stanar",
                column: "StanariZa");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_StanRefID",
                table: "Stanar",
                column: "StanRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_ZainteresovaniStanari",
                table: "Stanar",
                column: "ZainteresovaniStanari");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_ZgradaRefID",
                table: "Stanar",
                column: "ZgradaRefID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaOglasneTable_AutorID",
                table: "StavkaOglasneTable",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaOglasneTable_ZgradaRefID",
                table: "StavkaOglasneTable",
                column: "ZgradaRefID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obavestenje");

            migrationBuilder.DropTable(
                name: "Poruka");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "StavkaOglasneTable");

            migrationBuilder.DropTable(
                name: "Stanar");

            migrationBuilder.DropTable(
                name: "Predlog");

            migrationBuilder.DropTable(
                name: "Sastanak");

            migrationBuilder.DropTable(
                name: "Stan");

            migrationBuilder.DropTable(
                name: "Zgrada");
        }
    }
}
