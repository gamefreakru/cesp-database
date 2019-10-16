using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "feedback_user_fk",
                table: "feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks");

            migrationBuilder.DropColumn(
                name: "email",
                table: "users");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "users");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "feedbacks");

            migrationBuilder.RenameColumn(
                name: "signature",
                table: "feedbacks",
                newName: "lastname");

            migrationBuilder.AddColumn<string>(
                name: "contact",
                table: "users",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "feedbacks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_contact",
                table: "users",
                column: "contact",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_contact",
                table: "users");

            migrationBuilder.DropColumn(
                name: "contact",
                table: "users");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "feedbacks");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "feedbacks",
                newName: "signature");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "users",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "users",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "feedbacks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "feedback_user_fk",
                table: "feedbacks",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
