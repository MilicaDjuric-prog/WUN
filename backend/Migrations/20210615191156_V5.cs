using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanar_Sastanak_NezainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.DropForeignKey(
                name: "FK_Stanar_Sastanak_ZainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.DropIndex(
                name: "IX_Stanar_NezainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.DropIndex(
                name: "IX_Stanar_ZainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.DropColumn(
                name: "NezainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.DropColumn(
                name: "ZainteresovaniStanari",
                table: "Stanar");

            migrationBuilder.CreateTable(
                name: "StanarNeZaSastanak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StanarId = table.Column<int>(type: "int", nullable: false),
                    SastanakId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanarNeZaSastanak", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StanarZaSastanak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StanarId = table.Column<int>(type: "int", nullable: false),
                    SastanakId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanarZaSastanak", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StanarNeZaSastanak");

            migrationBuilder.DropTable(
                name: "StanarZaSastanak");

            migrationBuilder.AddColumn<int>(
                name: "NezainteresovaniStanari",
                table: "Stanar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZainteresovaniStanari",
                table: "Stanar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_NezainteresovaniStanari",
                table: "Stanar",
                column: "NezainteresovaniStanari");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_ZainteresovaniStanari",
                table: "Stanar",
                column: "ZainteresovaniStanari");

            migrationBuilder.AddForeignKey(
                name: "FK_Stanar_Sastanak_NezainteresovaniStanari",
                table: "Stanar",
                column: "NezainteresovaniStanari",
                principalTable: "Sastanak",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stanar_Sastanak_ZainteresovaniStanari",
                table: "Stanar",
                column: "ZainteresovaniStanari",
                principalTable: "Sastanak",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
