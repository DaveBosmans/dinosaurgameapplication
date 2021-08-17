using Microsoft.EntityFrameworkCore.Migrations;

namespace DinosaurAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dinosaurs",
                columns: table => new
                {
                    DinoModelID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DinoLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    DinosaurName = table.Column<string>(type: "TEXT", nullable: true),
                    TypeOfDino = table.Column<string>(type: "TEXT", nullable: true),
                    Health = table.Column<double>(type: "REAL", nullable: false),
                    Stamina = table.Column<double>(type: "REAL", nullable: false),
                    Strenght = table.Column<double>(type: "REAL", nullable: false),
                    Defence = table.Column<double>(type: "REAL", nullable: false),
                    Food = table.Column<double>(type: "REAL", nullable: false),
                    Intelligence = table.Column<double>(type: "REAL", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    DinoSoundLink = table.Column<string>(type: "TEXT", nullable: true),
                    UniqueString = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinosaurs", x => x.DinoModelID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dinosaurs");
        }
    }
}
