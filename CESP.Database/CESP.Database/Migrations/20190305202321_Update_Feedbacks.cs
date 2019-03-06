using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class Update_Feedbacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_users_feedback_user_fk",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_Teachers_teacher_meeting_fk",
                table: "speaking_club_meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "teachers");

            migrationBuilder.RenameColumn(
                name: "Post",
                table: "teachers",
                newName: "post");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "teachers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Info",
                table: "teachers",
                newName: "info");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "teachers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "feedback_user_fk",
                table: "feedbacks",
                newName: "feedback_source_id");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_feedback_user_fk",
                table: "feedbacks",
                newName: "IX_feedbacks_feedback_source_id");

            migrationBuilder.AlterColumn<string>(
                name: "post",
                table: "teachers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "teachers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "feedbacks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "feedbacks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "signature",
                table: "feedbacks",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers",
                table: "teachers",
                column: "id");

            migrationBuilder.CreateTable(
                name: "feedback_sources",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback_sources", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "feedback_source_fk",
                table: "feedbacks",
                column: "feedback_source_id",
                principalTable: "feedback_sources",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "feedback_user_fk",
                table: "feedbacks",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings",
                column: "teacher_meeting_fk",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "feedback_source_fk",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "feedback_user_fk",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings");

            migrationBuilder.DropTable(
                name: "feedback_sources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks");

            migrationBuilder.DropColumn(
                name: "date",
                table: "feedbacks");

            migrationBuilder.DropColumn(
                name: "signature",
                table: "feedbacks");

            migrationBuilder.RenameTable(
                name: "teachers",
                newName: "Teachers");

            migrationBuilder.RenameColumn(
                name: "post",
                table: "Teachers",
                newName: "Post");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Teachers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "info",
                table: "Teachers",
                newName: "Info");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "feedback_source_id",
                table: "feedbacks",
                newName: "feedback_user_fk");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_feedback_source_id",
                table: "feedbacks",
                newName: "IX_feedbacks_feedback_user_fk");

            migrationBuilder.AlterColumn<string>(
                name: "Post",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "feedbacks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_users_feedback_user_fk",
                table: "feedbacks",
                column: "feedback_user_fk",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_Teachers_teacher_meeting_fk",
                table: "speaking_club_meetings",
                column: "teacher_meeting_fk",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
