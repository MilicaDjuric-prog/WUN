using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotifikacijeStanara",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotifikacijaOglasna = table.Column<bool>(type: "bit", nullable: false),
                    NotifikacijaObavestenja = table.Column<bool>(type: "bit", nullable: false),
                    NotifikacijaCet = table.Column<bool>(type: "bit", nullable: false),
                    NotifikacijaPredlozi = table.Column<bool>(type: "bit", nullable: false),
                    NotifikacijaSastanci = table.Column<bool>(type: "bit", nullable: false),
                    NotifikacijaTroskovi = table.Column<bool>(type: "bit", nullable: false),
                    IdStanara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifikacijeStanara", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotifikacijeStanara");
        }
    }
}
