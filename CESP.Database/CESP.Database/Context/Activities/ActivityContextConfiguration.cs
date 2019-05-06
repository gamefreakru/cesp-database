using CESP.Database.Context.Activities.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Activities
{
    public static class ActivityContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureActivityTable(modelBuilder);
            ConfigureActivityFilesTable(modelBuilder);
        }

        private static void ConfigureActivityTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityDto>(entity =>
            {
                entity.ToTable("activities");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.SysName)
                    .HasColumnName("sysname")
                    .HasMaxLength(256)
                    .IsRequired();
                
                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();

                entity.Property(e => e.ShortInfo)
                    .HasColumnName("short_info");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .IsRequired();

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .IsRequired();

                entity.Property(e => e.End)
                    .HasColumnName("end")
                    .IsRequired(false);

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .IsRequired(false);

                entity.HasIndex(e => e.SysName)
                    .IsUnique();
                
                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("course_file_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }

        private static void ConfigureActivityFilesTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityFilesDto>(entity =>
                {
                    entity.ToTable("activity_files");

                    entity.HasKey(e => new {e.ActivityId, e.FileId});

                    entity.Property(e => e.ActivityId)
                        .HasColumnName("activity_id");

                    entity.Property(e => e.FileId)
                        .HasColumnName("file_id");

                    entity.HasOne(e => e.File)
                        .WithMany()
                        .HasForeignKey(e => e.FileId)
                        .HasConstraintName("activity_files_file_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                    
                    entity.HasOne(e => e.Activity)
                        .WithMany()
                        .HasForeignKey(e => e.ActivityId)
                        .HasConstraintName("activity_files_activity_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                }
            );
        }
    }
}