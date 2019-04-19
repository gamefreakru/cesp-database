using Microsoft.EntityFrameworkCore.Migrations;

namespace CESP.Database.Migrations
{
    public partial class SeedDictionaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "currencies",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "руб." });

            migrationBuilder.InsertData(
                table: "feedback_sources",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 4, "анкета" },
                    { 2, "vk" },
                    { 1, "facebook" },
                    { 3, "e-mail" }
                });

            migrationBuilder.InsertData(
                table: "language_levels",
                columns: new[] { "id", "info", "name", "native_name", "rang" },
                values: new object[,]
                {
                    { 14, null, "C2+", null, 15 },
                    { 12, null, "C2.2", null, 13 },
                    { 11, null, "C2.1", null, 12 },
                    { 10, null, "C1.2", null, 11 },
                    { 9, null, "C1.1", null, 10 },
                    { 8, null, "B2.3", null, 9 },
                    { 7, null, "B2.2", null, 8 },
                    { 6, null, "B2.1", null, 7 },
                    { 5, null, "B1.2", null, 6 },
                    { 4, null, "B1.1", null, 5 },
                    { 3, null, "A2.2", null, 4 },
                    { 2, null, "A2.1", null, 3 },
                    { 13, null, "C1+", null, 14 },
                    { 1, null, "A1", null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "currencies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "feedback_sources",
                keyColumn: "id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 14);
        }
    }
}
