using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "photo_id",
                table: "activities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sysname",
                table: "activities",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "activity_files",
                columns: table => new
                {
                    activity_id = table.Column<int>(nullable: false),
                    file_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activity_files", x => new { x.activity_id, x.file_id });
                    table.ForeignKey(
                        name: "activity_files_activity_fk",
                        column: x => x.activity_id,
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "activity_files_file_fk",
                        column: x => x.file_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activities_photo_id",
                table: "activities",
                column: "photo_id");

            migrationBuilder.CreateIndex(
                name: "IX_activities_sysname",
                table: "activities",
                column: "sysname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_activity_files_file_id",
                table: "activity_files",
                column: "file_id");

            migrationBuilder.AddForeignKey(
                name: "course_file_fk",
                table: "activities",
                column: "photo_id",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "course_file_fk",
                table: "activities");

            migrationBuilder.DropTable(
                name: "activity_files");

            migrationBuilder.DropIndex(
                name: "IX_activities_photo_id",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_sysname",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "photo_id",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "sysname",
                table: "activities");
        }
    }
}
