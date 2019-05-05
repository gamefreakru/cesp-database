using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateSchools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "sysname",
                table: "schools",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "school_files",
                columns: table => new
                {
                    school_id = table.Column<int>(nullable: false),
                    file_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_school_files", x => new { x.school_id, x.file_id });
                    table.ForeignKey(
                        name: "school_files_file_fk",
                        column: x => x.file_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "school_files_school_fk",
                        column: x => x.school_id,
                        principalTable: "schools",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schools_PhotoId",
                table: "schools",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_schools_sysname",
                table: "schools",
                column: "sysname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_school_files_file_id",
                table: "school_files",
                column: "file_id");

            migrationBuilder.AddForeignKey(
                name: "course_file_fk",
                table: "schools",
                column: "PhotoId",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "course_file_fk",
                table: "schools");

            migrationBuilder.DropTable(
                name: "school_files");

            migrationBuilder.DropIndex(
                name: "IX_schools_PhotoId",
                table: "schools");

            migrationBuilder.DropIndex(
                name: "IX_schools_sysname",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "schools");

            migrationBuilder.DropColumn(
                name: "sysname",
                table: "schools");
        }
    }
}
