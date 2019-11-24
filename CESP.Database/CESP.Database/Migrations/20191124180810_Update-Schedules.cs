using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class UpdateSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_durations");

            migrationBuilder.DropTable(
                name: "time_units");

            migrationBuilder.AddColumn<decimal>(
                name: "cost_full",
                table: "prices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "duration",
                table: "group_bunches",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cost_full",
                table: "prices");

            migrationBuilder.DropColumn(
                name: "duration",
                table: "group_bunches");

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
                    student_group_id = table.Column<int>(nullable: false),
                    time_unit_id = table.Column<int>(nullable: false)
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
                table: "time_units",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "ак.ч" },
                    { 2, "нед" },
                    { 3, "мес" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_durations_student_group_id",
                table: "group_durations",
                column: "student_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_durations_time_unit_id",
                table: "group_durations",
                column: "time_unit_id");
        }
    }
}
