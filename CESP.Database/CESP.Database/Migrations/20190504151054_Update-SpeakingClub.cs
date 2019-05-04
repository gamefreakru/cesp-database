using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateSpeakingClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "price_currency_fk",
                table: "prices");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_language_levels_max_language_meeting~",
                table: "speaking_club_meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_language_levels_min_language_meeting~",
                table: "speaking_club_meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "speaking_club_meetings",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "photo_id",
                table: "speaking_club_meetings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "short_info",
                table: "speaking_club_meetings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sysname",
                table: "speaking_club_meetings",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "group_times",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "group_bunches",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "sysname",
                table: "group_bunches",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "files",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sysname",
                table: "activities",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "activities",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "group_bunches",
                keyColumn: "id",
                keyValue: 1,
                column: "sysname",
                value: "adult");

            migrationBuilder.UpdateData(
                table: "group_bunches",
                keyColumn: "id",
                keyValue: 2,
                column: "sysname",
                value: "children");

            migrationBuilder.UpdateData(
                table: "group_bunches",
                keyColumn: "id",
                keyValue: 3,
                column: "sysname",
                value: "teen");

            migrationBuilder.UpdateData(
                table: "group_bunches",
                keyColumn: "id",
                keyValue: 4,
                column: "sysname",
                value: "catalan");

            migrationBuilder.UpdateData(
                table: "group_bunches",
                keyColumn: "id",
                keyValue: 5,
                column: "sysname",
                value: "schedules");

            migrationBuilder.CreateIndex(
                name: "IX_speaking_club_meetings_photo_id",
                table: "speaking_club_meetings",
                column: "photo_id");

            migrationBuilder.CreateIndex(
                name: "IX_speaking_club_meetings_sysname",
                table: "speaking_club_meetings",
                column: "sysname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_group_bunches_sysname",
                table: "group_bunches",
                column: "sysname",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "price_currency_fk",
                table: "prices",
                column: "currency_id",
                principalTable: "currencies",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "club_file_fk",
                table: "speaking_club_meetings",
                column: "photo_id",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_language_levels_max_language_meeting~",
                table: "speaking_club_meetings",
                column: "max_language_meeting_fk",
                principalTable: "language_levels",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_language_levels_min_language_meeting~",
                table: "speaking_club_meetings",
                column: "min_language_meeting_fk",
                principalTable: "language_levels",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings",
                column: "teacher_meeting_fk",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "price_currency_fk",
                table: "prices");

            migrationBuilder.DropForeignKey(
                name: "club_file_fk",
                table: "speaking_club_meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_language_levels_max_language_meeting~",
                table: "speaking_club_meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_language_levels_min_language_meeting~",
                table: "speaking_club_meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings");

            migrationBuilder.DropIndex(
                name: "IX_speaking_club_meetings_photo_id",
                table: "speaking_club_meetings");

            migrationBuilder.DropIndex(
                name: "IX_speaking_club_meetings_sysname",
                table: "speaking_club_meetings");

            migrationBuilder.DropIndex(
                name: "IX_group_bunches_sysname",
                table: "group_bunches");

            migrationBuilder.DropColumn(
                name: "photo_id",
                table: "speaking_club_meetings");

            migrationBuilder.DropColumn(
                name: "short_info",
                table: "speaking_club_meetings");

            migrationBuilder.DropColumn(
                name: "sysname",
                table: "speaking_club_meetings");

            migrationBuilder.DropColumn(
                name: "sysname",
                table: "group_bunches");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "speaking_club_meetings",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "group_times",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "group_bunches",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "files",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "sysname",
                table: "activities",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "activities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AddForeignKey(
                name: "price_currency_fk",
                table: "prices",
                column: "currency_id",
                principalTable: "currencies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_language_levels_max_language_meeting~",
                table: "speaking_club_meetings",
                column: "max_language_meeting_fk",
                principalTable: "language_levels",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_language_levels_min_language_meeting~",
                table: "speaking_club_meetings",
                column: "min_language_meeting_fk",
                principalTable: "language_levels",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                table: "speaking_club_meetings",
                column: "teacher_meeting_fk",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
