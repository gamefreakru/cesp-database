using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateStudentGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "teacher_id",
                table: "student_groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_student_groups_teacher_id",
                table: "student_groups",
                column: "teacher_id");

            migrationBuilder.AddForeignKey(
                name: "student_group_teacher_fk",
                table: "student_groups",
                column: "teacher_id",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "student_group_teacher_fk",
                table: "student_groups");

            migrationBuilder.DropIndex(
                name: "IX_student_groups_teacher_id",
                table: "student_groups");

            migrationBuilder.DropColumn(
                name: "teacher_id",
                table: "student_groups");
        }
    }
}
