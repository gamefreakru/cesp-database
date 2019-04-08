using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class AddTeachersPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "photo_id",
                table: "teachers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "files",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_files", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "files",
                columns: new[] { "id", "info", "name" },
                values: new object[,]
                {
                    { 1, "Йосу", "teachers/josu-foto.jpg" },
                    { 2, "Анхель", "teachers/anhel-photo.jpeg" },
                    { 3, "Рафаэль", "teachers/rafael_200x193.png" },
                    { 4, "Альберто", "teachers/alberto.jpg" },
                    { 5, "Хулио", "teachers/julio.jpg" },
                    { 6, "Алехо", "teachers/alejo.jpg" },
                    { 7, "Пабло", "teachers/pablo.jpeg" },
                    { 8, "Джонатан", "teachers/jonatan.jpg" },
                    { 9, "Юлия", "teachers/julia.png" }
                });

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 1,
                column: "photo_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 2,
                column: "photo_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 3,
                column: "photo_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 4,
                column: "photo_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 5,
                column: "photo_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 6,
                column: "photo_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 7,
                column: "photo_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 8,
                column: "photo_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "teachers",
                keyColumn: "id",
                keyValue: 9,
                column: "photo_id",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_teachers_photo_id",
                table: "teachers",
                column: "photo_id");

            migrationBuilder.AddForeignKey(
                name: "teacher_file_fk",
                table: "teachers",
                column: "photo_id",
                principalTable: "files",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "teacher_file_fk",
                table: "teachers");

            migrationBuilder.DropTable(
                name: "files");

            migrationBuilder.DropIndex(
                name: "IX_teachers_photo_id",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "photo_id",
                table: "teachers");
        }
    }
}
