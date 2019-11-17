using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class AddTeacherPhotosAndProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LargePhotoId",
                table: "teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortInfo",
                table: "teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SmallPhotoId",
                table: "teachers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_LargePhotoId",
                table: "teachers",
                column: "LargePhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_SmallPhotoId",
                table: "teachers",
                column: "SmallPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_files_LargePhotoId",
                table: "teachers",
                column: "LargePhotoId",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_files_SmallPhotoId",
                table: "teachers",
                column: "SmallPhotoId",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teachers_files_LargePhotoId",
                table: "teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_files_SmallPhotoId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_LargePhotoId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_SmallPhotoId",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "LargePhotoId",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "ShortInfo",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "SmallPhotoId",
                table: "teachers");
        }
    }
}
