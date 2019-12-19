using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "priority",
                table: "group_times",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "priority",
                table: "group_bunches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price_info",
                table: "cources",
                maxLength: 256,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "course_files",
                columns: table => new
                {
                    course_id = table.Column<int>(nullable: false),
                    file_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_files", x => new { x.file_id, x.course_id });
                    table.ForeignKey(
                        name: "course_file_course_fk",
                        column: x => x.course_id,
                        principalTable: "cources",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "course_file_file_fk",
                        column: x => x.file_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_course_files_course_id",
                table: "course_files",
                column: "course_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_files");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "group_times");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "group_bunches");

            migrationBuilder.DropColumn(
                name: "price_info",
                table: "cources");
        }
    }
}
