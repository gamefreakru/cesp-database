﻿// <auto-generated />

using System;
using CESP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CESP.Database.Migrations
{
    [DbContext(typeof(CespContext))]
    partial class CespContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CESP.Database.Context.Activities.Models.ActivityDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("End")
                        .HasColumnName("end");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.Property<DateTime>("Start")
                        .HasColumnName("start");

                    b.HasKey("Id");

                    b.ToTable("activities");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.CourseDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("DurationInfo")
                        .HasColumnName("duration_info");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("InstructionPdf")
                        .HasColumnName("instruction_pdf");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NativeInfo")
                        .HasColumnName("native_info");

                    b.Property<string>("NativeName")
                        .HasColumnName("native_name")
                        .HasMaxLength(256);

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.HasKey("Id");

                    b.ToTable("cources");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.LanguageLevelDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NativeName")
                        .HasColumnName("native_name")
                        .HasMaxLength(256);

                    b.Property<int?>("Rang")
                        .HasColumnName("rang");

                    b.HasKey("Id");

                    b.ToTable("language_levels");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.SpeakingClubMeetingDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<int?>("MaxLanguageLevelId")
                        .HasColumnName("max_language_level_id");

                    b.Property<int?>("MinLanguageLevelId")
                        .HasColumnName("min_language_level_id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int?>("TeacherId")
                        .HasColumnName("teacher_id");

                    b.Property<int?>("max_language_meeting_fk");

                    b.Property<int?>("min_language_meeting_fk");

                    b.Property<int?>("teacher_meeting_fk");

                    b.HasKey("Id");

                    b.HasIndex("max_language_meeting_fk");

                    b.HasIndex("min_language_meeting_fk");

                    b.HasIndex("teacher_meeting_fk");

                    b.ToTable("speaking_club_meetings");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int?>("CountStudentsMax")
                        .HasColumnName("count_students_max");

                    b.Property<int?>("CountStudentsMin")
                        .HasColumnName("count_students_min");

                    b.Property<int>("CourseId")
                        .HasColumnName("course_id");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<bool>("IsAvailable")
                        .HasColumnName("available");

                    b.Property<DateTime>("Start")
                        .HasColumnName("date_start");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("student_groups");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupPriceDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("PriceId");

                    b.Property<int>("StudentGroupId")
                        .HasColumnName("student_group_id");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("student_group_prices");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.TeacherDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Info");

                    b.Property<string>("Name");

                    b.Property<string>("Post");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CESP.Database.Context.Models.Press.Models.PressDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("BlogUrl")
                        .HasColumnName("blog_url");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("Source")
                        .HasColumnName("source")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("presses");
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.CurrencyDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("currencies");
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.PaymentPeriodDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnName("info")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("payment_periods");
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.PriceDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<decimal>("Cost")
                        .HasColumnName("cost");

                    b.Property<int>("CurrencyId")
                        .HasColumnName("currency_id");

                    b.Property<decimal?>("Discount")
                        .HasColumnName("discount");

                    b.Property<int?>("DiscountPer")
                        .HasColumnName("discounter");

                    b.Property<int>("PaymentPeriodId")
                        .HasColumnName("payment_period_id");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("PaymentPeriodId");

                    b.ToTable("prices");
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDayDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("schedule_days");
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("EndLessonTime")
                        .HasColumnName("lesson_end");

                    b.Property<int>("ScheduleDayId")
                        .HasColumnName("schedule_day_id");

                    b.Property<DateTime>("StartLessonTime")
                        .HasColumnName("lesson_start");

                    b.Property<int>("StudentGroupId")
                        .HasColumnName("student_group_id");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleDayId");

                    b.HasIndex("StudentGroupId");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("CESP.Database.Context.Schools.Models.Schools.SchoolDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Info")
                        .HasColumnName("info");

                    b.Property<string>("Location")
                        .HasColumnName("location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("ShortInfo")
                        .HasColumnName("short_info");

                    b.HasKey("Id");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.FeedbackDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.Property<int?>("feedback_user_fk");

                    b.HasKey("Id");

                    b.HasIndex("feedback_user_fk");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.SpeakingClubMeetingDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "MaxLanguageLevel")
                        .WithMany()
                        .HasForeignKey("max_language_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.LanguageLevelDto", "MinLanguageLevel")
                        .WithMany()
                        .HasForeignKey("min_language_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.TeacherDto", "Teacher")
                        .WithMany()
                        .HasForeignKey("teacher_meeting_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Education.Models.CourseDto", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("student_group_course_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Education.Models.StudentGroupPriceDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Payments.Models.PriceDto", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CESP.Database.Context.Education.Models.StudentGroupDto", "StudentGroup")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("student_group_price_student_group_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Payments.Models.PriceDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Payments.Models.CurrencyDto", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .HasConstraintName("price_currency_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Payments.Models.PaymentPeriodDto", "PaymentPeriod")
                        .WithMany()
                        .HasForeignKey("PaymentPeriodId")
                        .HasConstraintName("price_payment_period_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CESP.Database.Context.Schedules.Models.ScheduleDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Schedules.Models.ScheduleDayDto", "ScheduleDay")
                        .WithMany()
                        .HasForeignKey("ScheduleDayId")
                        .HasConstraintName("schedule_schedule_day_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CESP.Database.Context.Education.Models.StudentGroupDto", "StudentGroupDto")
                        .WithMany()
                        .HasForeignKey("StudentGroupId")
                        .HasConstraintName("schedule_student_group_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CESP.Database.Context.Users.Models.FeedbackDto", b =>
                {
                    b.HasOne("CESP.Database.Context.Users.Models.UserDto", "User")
                        .WithMany()
                        .HasForeignKey("feedback_user_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
