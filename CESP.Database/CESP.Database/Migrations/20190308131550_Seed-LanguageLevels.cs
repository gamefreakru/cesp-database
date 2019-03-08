using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class SeedLanguageLevels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "language_levels",
                columns: new[] { "id", "info", "name", "native_name", "rang" },
                values: new object[,]
                {
                    { 1, null, "A1.1", null, 1 },
                    { 2, null, "A1.2", null, 2 },
                    { 3, null, "A2.1", null, 3 },
                    { 4, null, "A2.2", null, 4 },
                    { 5, null, "B1.1", null, 5 },
                    { 6, null, "B1.2", null, 6 },
                    { 7, null, "B2.1", null, 7 },
                    { 8, null, "B2.2", null, 8 },
                    { 9, null, "C1.1", null, 9 },
                    { 10, null, "C1.2", null, 10 },
                    { 11, null, "C2.1", null, 11 },
                    { 12, null, "C2.2", null, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 12);
        }
    }
}
