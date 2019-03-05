using CESP.Database.Context.Schedules.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Schedules
{
    public static class SchedulesContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureScheduleTable(modelBuilder);
            ConfigureScheduleDay(modelBuilder);
        }
        
        private static void ConfigureScheduleTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduleDto>(entity =>
            {
                entity.ToTable("schedules");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.StartLessonTime)
                    .HasColumnName("lesson_start")
                    .IsRequired();

                entity.Property(e => e.EndLessonTime)
                    .HasColumnName("lesson_end")
                    .IsRequired();
                
                entity.Property(e => e.ScheduleDayId)
                    .HasColumnName("schedule_day_id");

                entity.HasOne(e => e.ScheduleDay)
                    .WithMany()
                    .HasForeignKey(e => e.ScheduleDayId)
                    .HasConstraintName("schedule_schedule_day_fk")
                    .OnDelete(DeleteBehavior.Restrict);
                
                entity.Property(e => e.StudentGroupId)
                    .HasColumnName("student_group_id");

                entity.HasOne(e => e.StudentGroup)
                    .WithMany()
                    .HasForeignKey(e => e.StudentGroupId)
                    .HasConstraintName("schedule_student_group_fk")
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        private static void ConfigureScheduleDay(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduleDayDto>(entity =>
            {
                entity.ToTable("schedule_days");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");
                
                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });
        }
    }
}