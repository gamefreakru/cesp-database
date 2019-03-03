using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    short_info = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    start = table.Column<DateTime>(nullable: false),
                    end = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cources",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    native_name = table.Column<string>(maxLength: 256, nullable: true),
                    short_info = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    native_info = table.Column<string>(nullable: true),
                    duration_info = table.Column<string>(nullable: true),
                    instruction_pdf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cources", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currencies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language_levels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    native_name = table.Column<string>(maxLength: 256, nullable: true),
                    info = table.Column<string>(nullable: true),
                    rang = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language_levels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payment_periods",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    info = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_periods", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "presses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    info = table.Column<string>(nullable: true),
                    blog_url = table.Column<string>(nullable: true),
                    source = table.Column<string>(maxLength: 256, nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schedule_days",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_days", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schools",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: false),
                    location = table.Column<string>(nullable: true),
                    short_info = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schools", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    email = table.Column<string>(maxLength: 256, nullable: true),
                    phone = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "student_groups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    course_id = table.Column<int>(nullable: false),
                    date_start = table.Column<DateTime>(nullable: false),
                    available = table.Column<bool>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    count_students_min = table.Column<int>(nullable: true),
                    count_students_max = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_groups", x => x.id);
                    table.ForeignKey(
                        name: "student_group_course_fk",
                        column: x => x.course_id,
                        principalTable: "cources",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    cost = table.Column<decimal>(nullable: false),
                    discounter = table.Column<int>(nullable: true),
                    discount = table.Column<decimal>(nullable: true),
                    currency_id = table.Column<int>(nullable: false),
                    payment_period_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.id);
                    table.ForeignKey(
                        name: "price_currency_fk",
                        column: x => x.currency_id,
                        principalTable: "currencies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "price_payment_period_fk",
                        column: x => x.payment_period_id,
                        principalTable: "payment_periods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "speaking_club_meetings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    info = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    teacher_id = table.Column<int>(nullable: true),
                    teacher_meeting_fk = table.Column<int>(nullable: true),
                    min_language_level_id = table.Column<int>(nullable: true),
                    min_language_meeting_fk = table.Column<int>(nullable: true),
                    max_language_level_id = table.Column<int>(nullable: true),
                    max_language_meeting_fk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speaking_club_meetings", x => x.id);
                    table.ForeignKey(
                        name: "FK_speaking_club_meetings_language_levels_max_language_meeting~",
                        column: x => x.max_language_meeting_fk,
                        principalTable: "language_levels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_speaking_club_meetings_language_levels_min_language_meeting~",
                        column: x => x.min_language_meeting_fk,
                        principalTable: "language_levels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_speaking_club_meetings_Teachers_teacher_meeting_fk",
                        column: x => x.teacher_meeting_fk,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    user_id = table.Column<int>(nullable: false),
                    message = table.Column<string>(nullable: false),
                    feedback_user_fk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "FK_feedbacks_users_feedback_user_fk",
                        column: x => x.feedback_user_fk,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    student_group_id = table.Column<int>(nullable: false),
                    schedule_day_id = table.Column<int>(nullable: false),
                    lesson_start = table.Column<DateTime>(nullable: false),
                    lesson_end = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                    table.ForeignKey(
                        name: "schedule_schedule_day_fk",
                        column: x => x.schedule_day_id,
                        principalTable: "schedule_days",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "schedule_student_group_fk",
                        column: x => x.student_group_id,
                        principalTable: "student_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "student_group_prices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    student_group_id = table.Column<int>(nullable: false),
                    PriceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_group_prices", x => x.id);
                    table.ForeignKey(
                        name: "FK_student_group_prices_prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "prices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "student_group_price_student_group_fk",
                        column: x => x.student_group_id,
                        principalTable: "student_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_feedback_user_fk",
                table: "feedbacks",
                column: "feedback_user_fk");

            migrationBuilder.CreateIndex(
                name: "IX_prices_currency_id",
                table: "prices",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_prices_payment_period_id",
                table: "prices",
                column: "payment_period_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_schedule_day_id",
                table: "schedules",
                column: "schedule_day_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_student_group_id",
                table: "schedules",
                column: "student_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_speaking_club_meetings_max_language_meeting_fk",
                table: "speaking_club_meetings",
                column: "max_language_meeting_fk");

            migrationBuilder.CreateIndex(
                name: "IX_speaking_club_meetings_min_language_meeting_fk",
                table: "speaking_club_meetings",
                column: "min_language_meeting_fk");

            migrationBuilder.CreateIndex(
                name: "IX_speaking_club_meetings_teacher_meeting_fk",
                table: "speaking_club_meetings",
                column: "teacher_meeting_fk");

            migrationBuilder.CreateIndex(
                name: "IX_student_group_prices_PriceId",
                table: "student_group_prices",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_student_group_prices_student_group_id",
                table: "student_group_prices",
                column: "student_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_student_groups_course_id",
                table: "student_groups",
                column: "course_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activities");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "presses");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropTable(
                name: "schools");

            migrationBuilder.DropTable(
                name: "speaking_club_meetings");

            migrationBuilder.DropTable(
                name: "student_group_prices");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "schedule_days");

            migrationBuilder.DropTable(
                name: "language_levels");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "student_groups");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropTable(
                name: "payment_periods");

            migrationBuilder.DropTable(
                name: "cources");
        }
    }
}
