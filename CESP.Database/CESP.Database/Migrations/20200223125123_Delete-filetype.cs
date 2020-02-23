using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class Deletefiletype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file_type",
                table: "course_files");

            migrationBuilder.AddColumn<int>(
                name: "file_type",
                table: "files",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file_type",
                table: "files");

            migrationBuilder.AddColumn<int>(
                name: "file_type",
                table: "course_files",
                nullable: false,
                defaultValue: 0);
        }
    }
}
