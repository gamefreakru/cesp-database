using Centroespanol.Database.Context.Education;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Payments.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Education
{
    public static class EducationContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureStudentGroupTable(modelBuilder);
            ConfigureCourseTable(modelBuilder);
            ConfigureLanguageLevelTable(modelBuilder);
            ConfigureSpeakingClubMeetingTable(modelBuilder);
            ConfigureTeacherTable(modelBuilder);
            
            EducationSeed.Seed(modelBuilder);
        }

        private static void ConfigureTeacherTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherDto>(entity =>
            {
                entity.ToTable("teachers");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();
                
                entity.Property(e => e.Post)
                    .HasColumnName("post")
                    .HasMaxLength(256);

                entity.Property(e => e.Info)
                    .HasColumnName("info");
                
                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .IsRequired(false);

                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("teacher_file_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }
        
        private static void ConfigureLanguageLevelTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageLevelDto>(entity =>
            {
                entity.ToTable("language_levels");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.NativeName)
                    .HasColumnName("native_name")
                    .HasMaxLength(256);

                entity.Property(e => e.Rang)
                    .HasColumnName("rang")
                    .IsRequired(false);

                entity.Property(e => e.Info)
                    .HasColumnName("info");
            });
        }
        
        private static void ConfigureCourseTable(ModelBuilder modelBuilder)
        {       
            modelBuilder.Entity<CourseDto>(entity =>
            {
                entity.ToTable("cources");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Description)
                    .HasColumnName("short_info");


                entity.Property(e => e.DurationInfo)
                    .HasColumnName("duration_info");

                entity.HasMany<PriceDto>(e => e.Prices);
                 
                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .IsRequired(false);

                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("course_file_fk")
                    .OnDelete(DeleteBehavior.SetNull);
                
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
                    .IsRequired(true);

                entity.Property(e => e.IsWorking)
                    .HasColumnName("working")
                    .IsRequired(true);

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id");

                entity.HasOne(e => e.Course)
                    .WithMany()
                    .HasForeignKey(e => e.CourseId)
                    .HasConstraintName("student_group_course_fk")
                    .OnDelete(DeleteBehavior.Cascade);

            });
        }
        
        private static void ConfigureSpeakingClubMeetingTable(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SpeakingClubMeetingDto>(entity =>
            {
                entity.ToTable("speaking_club_meetings");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.Info)
                    .HasColumnName("info");

                entity.Property(e => e.Date)
                    .HasColumnName("date");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("teacher_id");
                
                entity.HasOne(e => e.Teacher)
                    .WithMany()
                    .HasForeignKey("teacher_meeting_fk")
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.MinLanguageLevelId)
                    .HasColumnName("min_language_level_id")
                    .IsRequired(false);
                
                entity.HasOne(e => e.MinLanguageLevel)
                    .WithMany()
                    .HasForeignKey("min_language_meeting_fk")
                    .OnDelete(DeleteBehavior.Restrict);
                
                entity.Property(e => e.MaxLanguageLevelId)
                    .HasColumnName("max_language_level_id")
                    .IsRequired(false);
                    
                entity.HasOne(e => e.MaxLanguageLevel)
                    .WithMany()
                    .HasForeignKey("max_language_meeting_fk")
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}