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
                name: "cources",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    short_info = table.Column<string>(nullable: true),
                    duration_info = table.Column<string>(nullable: true),
                    photo_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cources", x => x.id);
                    table.ForeignKey(
                        name: "course_file_fk",
                        column: x => x.photo_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 256, nullable: false),
                    post = table.Column<string>(maxLength: 256, nullable: true),
                    info = table.Column<string>(nullable: true),
                    photo_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.id);
                    table.ForeignKey(
                        name: "teacher_file_fk",
                        column: x => x.photo_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    message = table.Column<string>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    signature = table.Column<string>(nullable: true),
                    source_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    photo_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "feedback_photo_fk",
                        column: x => x.photo_id,
                        principalTable: "files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "feedback_source_fk",
                        column: x => x.source_id,
                        principalTable: "feedback_sources",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "feedback_user_fk",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "student_groups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    course_id = table.Column<int>(nullable: false),
                    date_start = table.Column<DateTime>(nullable: true),
                    available = table.Column<bool>(nullable: false),
                    working = table.Column<bool>(nullable: false),
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
                        name: "FK_speaking_club_meetings_teachers_teacher_meeting_fk",
                        column: x => x.teacher_meeting_fk,
                        principalTable: "teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    cost = table.Column<decimal>(nullable: false),
                    cost_info = table.Column<string>(maxLength: 256, nullable: true),
                    discounter = table.Column<int>(nullable: true),
                    discount_info = table.Column<string>(maxLength: 256, nullable: true),
                    payment_period = table.Column<string>(maxLength: 256, nullable: true),
                    currency_id = table.Column<int>(nullable: false),
                    group_id = table.Column<int>(nullable: false),
                    CourseDtoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.id);
                    table.ForeignKey(
                        name: "FK_prices_cources_CourseDtoId",
                        column: x => x.CourseDtoId,
                        principalTable: "cources",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "price_currency_fk",
                        column: x => x.currency_id,
                        principalTable: "currencies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "price_student_group_fk",
                        column: x => x.group_id,
                        principalTable: "student_groups",
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
                    day = table.Column<string>(maxLength: 256, nullable: false),
                    lesson_start = table.Column<TimeSpan>(nullable: false),
                    lesson_end = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                    table.ForeignKey(
                        name: "schedule_student_group_fk",
                        column: x => x.student_group_id,
                        principalTable: "student_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cources_photo_id",
                table: "cources",
                column: "photo_id");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_photo_id",
                table: "feedbacks",
                column: "photo_id");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_source_id",
                table: "feedbacks",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_prices_CourseDtoId",
                table: "prices",
                column: "CourseDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_prices_currency_id",
                table: "prices",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_prices_group_id",
                table: "prices",
                column: "group_id");

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
                name: "IX_student_groups_course_id",
                table: "student_groups",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_photo_id",
                table: "teachers",
                column: "photo_id");
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
                name: "prices");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropTable(
                name: "schools");

            migrationBuilder.DropTable(
                name: "speaking_club_meetings");

            migrationBuilder.DropTable(
                name: "feedback_sources");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropTable(
                name: "student_groups");

            migrationBuilder.DropTable(
                name: "language_levels");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "cources");

            migrationBuilder.DropTable(
                name: "files");
        }
    }
}
