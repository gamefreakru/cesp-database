using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class UpdateLanguageLevelAddDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "native_name",
                table: "language_levels");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "language_levels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "language_levels");

            migrationBuilder.AddColumn<string>(
                name: "native_name",
                table: "language_levels",
                maxLength: 256,
                nullable: true);
        }
    }
}
