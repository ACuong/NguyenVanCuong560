using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenVanCuong560.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVC0560",
                columns: table => new
                {
                    NVCID = table.Column<string>(type: "TEXT", nullable: false),
                    NVCName = table.Column<string>(type: "TEXT", nullable: true),
                    NVCGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVC0560", x => x.NVCID);
                });

            migrationBuilder.CreateTable(
                name: "UniversityNVC560",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNVC560", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVC0560");

            migrationBuilder.DropTable(
                name: "UniversityNVC560");
        }
    }
}
