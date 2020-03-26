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
            ConfigureCourseTable(modelBuilder);
            ConfigureCourseFileTable(modelBuilder);
            ConfigureLanguageLevelTable(modelBuilder);
            ConfigureSpeakingClubMeetingTable(modelBuilder);
            ConfigureTeacherTable(modelBuilder);
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

                entity.Property(e => e.Rang)
                    .HasColumnName("rang")
                    .IsRequired()
                    .HasDefaultValue(0);

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

                entity.Property(e => e.Description)
                    .HasColumnName("description");

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

                entity.Property(e => e.PriceInfo)
                    .HasColumnName("price_info")
                    .HasMaxLength(256);

                entity.Property(e => e.Description)
                    .HasColumnName("short_info");

                entity.Property(e => e.DurationInfo)
                    .HasColumnName("duration_info");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValue(0);
                
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

        private static void ConfigureCourseFileTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseFileDto>()
                .ToTable("course_files")
                .HasKey(e => new {e.FileId, e.CourseId});
            modelBuilder.Entity<CourseFileDto>()
                .Property(e => e.Priority)
                .HasColumnName("priority")
                .IsRequired(false);
            modelBuilder.Entity<CourseFileDto>()
                .Property(e => e.CourseId)
                .HasColumnName("course_id")
                .IsRequired();
            modelBuilder.Entity<CourseFileDto>()
                .HasOne(e => e.Course)
                .WithMany(e => e.CourseFiles)
                .HasForeignKey(e => e.CourseId)
                .HasConstraintName("course_file_course_fk")
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CourseFileDto>()
                .Property(e => e.FileId)
                .HasColumnName("file_id")
                .IsRequired();
            modelBuilder.Entity<CourseFileDto>()
                .HasOne(e => e.File)
                .WithMany(e => e.CourseFiles)
                .HasForeignKey(e => e.FileId)
                .HasConstraintName("course_file_file_fk")
                .OnDelete(DeleteBehavior.Cascade);
    }

    private static void ConfigureSpeakingClubMeetingTable(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<SpeakingClubMeetingDto>(entity =>
    {
        entity.ToTable("speaking_club_meetings");

        entity.HasKey(e => e.Id);

        entity.Property(e => e.Id)
            .HasColumnName("id");

        entity.Property(e => e.SysName)
            .HasColumnName("sysname")
            .IsRequired()
            .HasMaxLength(256);

        entity.HasIndex(e => e.SysName)
            .IsUnique();

        entity.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(256);

        entity.Property(e => e.ShortInfo)
            .HasColumnName("short_info");

        entity.Property(e => e.Info)
            .HasColumnName("info");

        entity.Property(e => e.Date)
            .HasColumnName("date")
            .IsRequired();

        entity.Property(e => e.TeacherId)
            .HasColumnName("teacher_id");

        entity.HasOne(e => e.Teacher)
            .WithMany()
            .HasForeignKey(e => e.TeacherId)
            .HasConstraintName("teacher_meeting_fk")
            .OnDelete(DeleteBehavior.SetNull);

        entity.Property(e => e.MinLanguageLevelId)
            .HasColumnName("min_language_level_id")
            .IsRequired(false);

        entity.HasOne(e => e.MinLanguageLevel)
            .WithMany()
            .HasForeignKey(e => e.MinLanguageLevelId)
            .HasConstraintName("min_language_meeting_fk")
            .OnDelete(DeleteBehavior.SetNull);

        entity.Property(e => e.MaxLanguageLevelId)
            .HasColumnName("max_language_level_id")
            .IsRequired(false);

        entity.HasOne(e => e.MaxLanguageLevel)
            .WithMany()
            .HasForeignKey(e => e.MaxLanguageLevelId)
            .HasConstraintName("max_language_meeting_fk")
            .OnDelete(DeleteBehavior.SetNull);

        entity.Property(e => e.PhotoId)
            .HasColumnName("photo_id")
            .IsRequired(false);

        entity.HasOne(e => e.Photo)
            .WithMany()
            .HasForeignKey(e => e.PhotoId)
            .HasConstraintName("club_file_fk")
            .OnDelete(DeleteBehavior.SetNull);
    });
}

}
}