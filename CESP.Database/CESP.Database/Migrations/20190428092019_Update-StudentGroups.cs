using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class UpdateStudentGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "schedule_student_group_fk",
                table: "schedules");

            migrationBuilder.AlterColumn<int>(
                name: "course_id",
                table: "student_groups",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "group_bunch_id",
                table: "student_groups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "group_time_id",
                table: "student_groups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "language_level_id",
                table: "student_groups",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "group_bunches",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_bunches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group_times",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_times", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "time_units",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_time_units", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group_durations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    duration = table.Column<double>(nullable: false),
                    time_unit_id = table.Column<int>(nullable: false),
                    student_group_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_durations", x => x.id);
                    table.ForeignKey(
                        name: "group_duration_student_group_fk",
                        column: x => x.student_group_id,
                        principalTable: "student_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "group_duration_time_unit_fk",
                        column: x => x.time_unit_id,
                        principalTable: "time_units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "group_bunches",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Взрослые группы" },
                    { 5, "РАСПИСАНИЕ И ЦЕНЫ" },
                    { 4, "Группы каталонского языка" },
                    { 3, "Молодежные и подростковые группы" },
                    { 2, "Детские группы" }
                });

            migrationBuilder.InsertData(
                table: "group_times",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 4, "Курс выходного дня" },
                    { 3, "Вечерний курс" },
                    { 2, "Дневной курс" },
                    { 1, "Утренний курс" }
                });

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 1,
                column: "info",
                value: "Начальный уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 2,
                column: "info",
                value: "Базовый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 3,
                column: "info",
                value: "Базовый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 4,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 5,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 6,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 7,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 8,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 9,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 10,
                column: "info",
                value: "Продвинутый уровень");

            migrationBuilder.InsertData(
                table: "time_units",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 2, "нед" },
                    { 1, "ак.ч" },
                    { 3, "мес" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_student_groups_group_bunch_id",
                table: "student_groups",
                column: "group_bunch_id");

            migrationBuilder.CreateIndex(
                name: "IX_student_groups_group_time_id",
                table: "student_groups",
                column: "group_time_id");

            migrationBuilder.CreateIndex(
                name: "IX_student_groups_language_level_id",
                table: "student_groups",
                column: "language_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_durations_student_group_id",
                table: "group_durations",
                column: "student_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_durations_time_unit_id",
                table: "group_durations",
                column: "time_unit_id");

            migrationBuilder.AddForeignKey(
                name: "schedule_student_group_fk",
                table: "schedules",
                column: "student_group_id",
                principalTable: "student_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "group_group_bunch_fk",
                table: "student_groups",
                column: "group_bunch_id",
                principalTable: "group_bunches",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "group_group_time_fk",
                table: "student_groups",
                column: "group_time_id",
                principalTable: "group_times",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "group_language_level_fk",
                table: "student_groups",
                column: "language_level_id",
                principalTable: "language_levels",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "schedule_student_group_fk",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "group_group_bunch_fk",
                table: "student_groups");

            migrationBuilder.DropForeignKey(
                name: "group_group_time_fk",
                table: "student_groups");

            migrationBuilder.DropForeignKey(
                name: "group_language_level_fk",
                table: "student_groups");

            migrationBuilder.DropTable(
                name: "group_bunches");

            migrationBuilder.DropTable(
                name: "group_durations");

            migrationBuilder.DropTable(
                name: "group_times");

            migrationBuilder.DropTable(
                name: "time_units");

            migrationBuilder.DropIndex(
                name: "IX_student_groups_group_bunch_id",
                table: "student_groups");

            migrationBuilder.DropIndex(
                name: "IX_student_groups_group_time_id",
                table: "student_groups");

            migrationBuilder.DropIndex(
                name: "IX_student_groups_language_level_id",
                table: "student_groups");

            migrationBuilder.DropColumn(
                name: "group_bunch_id",
                table: "student_groups");

            migrationBuilder.DropColumn(
                name: "group_time_id",
                table: "student_groups");

            migrationBuilder.DropColumn(
                name: "language_level_id",
                table: "student_groups");

            migrationBuilder.AlterColumn<int>(
                name: "course_id",
                table: "student_groups",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 1,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 2,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 3,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 4,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 5,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 6,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 7,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 8,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 9,
                column: "info",
                value: null);

            migrationBuilder.UpdateData(
                table: "language_levels",
                keyColumn: "id",
                keyValue: 10,
                column: "info",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "schedule_student_group_fk",
                table: "schedules",
                column: "student_group_id",
                principalTable: "student_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
