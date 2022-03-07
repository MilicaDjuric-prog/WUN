using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanar_Predlog_StanariProtiv",
                table: "Stanar");

            migrationBuilder.DropForeignKey(
                name: "FK_Stanar_Predlog_StanariZa",
                table: "Stanar");

            migrationBuilder.DropIndex(
                name: "IX_Stanar_StanariProtiv",
                table: "Stanar");

            migrationBuilder.DropIndex(
                name: "IX_Stanar_StanariZa",
                table: "Stanar");

            migrationBuilder.DropColumn(
                name: "StanariProtiv",
                table: "Stanar");

            migrationBuilder.DropColumn(
                name: "StanariZa",
                table: "Stanar");

            migrationBuilder.CreateTable(
                name: "StanarGlasaoProtivPredloga",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StanarId = table.Column<int>(type: "int", nullable: false),
                    PredlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanarGlasaoProtivPredloga", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StanarGlasaoZaPredlog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StanarId = table.Column<int>(type: "int", nullable: false),
                    PredlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanarGlasaoZaPredlog", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StanarGlasaoProtivPredloga");

            migrationBuilder.DropTable(
                name: "StanarGlasaoZaPredlog");

            migrationBuilder.AddColumn<int>(
                name: "StanariProtiv",
                table: "Stanar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StanariZa",
                table: "Stanar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_StanariProtiv",
                table: "Stanar",
                column: "StanariProtiv");

            migrationBuilder.CreateIndex(
                name: "IX_Stanar_StanariZa",
                table: "Stanar",
                column: "StanariZa");

            migrationBuilder.AddForeignKey(
                name: "FK_Stanar_Predlog_StanariProtiv",
                table: "Stanar",
                column: "StanariProtiv",
                principalTable: "Predlog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stanar_Predlog_StanariZa",
                table: "Stanar",
                column: "StanariZa",
                principalTable: "Predlog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
