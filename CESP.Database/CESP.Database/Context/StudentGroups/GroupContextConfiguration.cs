using CESP.Database.Context.StudentGroups.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.StudentGroups
{
    public static class GroupContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureGroupTimeTable(modelBuilder);
            ConfigureStudentGroupTable(modelBuilder);
            ConfigureGroupBunchTable(modelBuilder);

            GroupSeed.Seed(modelBuilder);
        }

        private static void ConfigureGroupBunchTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupBunchDto>(entity =>
            {
                entity.ToTable("group_bunches");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();
                
                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasMaxLength(256)
                    .IsRequired(false);

                entity.Property(e => e.SysName)
                    .HasColumnName("sysname")
                    .HasMaxLength(256)
                    .IsRequired();
                
                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .IsRequired(false);

                entity.HasIndex(e => e.SysName)
                    .IsUnique();
            });
        }

        private static void ConfigureGroupTimeTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupTimeDto>(entity =>
            {
                entity.ToTable("group_times");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");
                
                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .IsRequired(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();
            });
        }

        private static void ConfigureStudentGroupTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentGroupDto>(entity =>
            {
                entity.ToTable("student_groups");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description");

                entity.Property(e => e.Start)
                    .HasColumnName("date_start")
                    .IsRequired(false);

                entity.Property(e => e.CountStudentsMin)
                    .HasColumnName("count_students_min")
                    .IsRequired(false);

                entity.Property(e => e.CountStudentsMax)
                    .HasColumnName("count_students_max")
                    .IsRequired(false);

                entity.Property(e => e.IsAvailable)
                    .HasColumnName("available")
                    .IsRequired();

                entity.Property(e => e.IsWorking)
                    .HasColumnName("working")
                    .IsRequired();

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Course)
                    .WithMany()
                    .HasForeignKey(e => e.CourseId)
                    .HasConstraintName("student_group_course_fk")
                    .OnDelete(DeleteBehavior.Cascade);
                
                entity.Property(e => e.TeacherId)
                    .HasColumnName("teacher_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Teacher)
                    .WithMany()
                    .HasForeignKey(e => e.TeacherId)
                    .HasConstraintName("student_group_teacher_fk")
                    .OnDelete(DeleteBehavior.SetNull);

                entity.Property(e => e.GroupTimeId)
                    .HasColumnName("group_time_id")
                    .IsRequired(false);
                entity.HasOne(e => e.GroupTime)
                    .WithMany()
                    .HasForeignKey(e => e.GroupTimeId)
                    .HasConstraintName("group_group_time_fk")
                    .OnDelete(DeleteBehavior.SetNull);
                
                entity.Property(e => e.GroupBunchId)
                    .HasColumnName("group_bunch_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Bunch)
                    .WithMany()
                    .HasForeignKey(e => e.GroupBunchId)
                    .HasConstraintName("group_group_bunch_fk")
                    .OnDelete(DeleteBehavior.SetNull);

                entity.Property(e => e.LanguageLevelId)
                    .HasColumnName("language_level_id")
                    .IsRequired(false);
                entity.HasOne(e => e.LanguageLevel)
                    .WithMany()
                    .HasForeignKey(e => e.LanguageLevelId)
                    .HasConstraintName("group_language_level_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}