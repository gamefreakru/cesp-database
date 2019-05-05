using CESP.Database.Context.Schools.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Schools
{
    public static class SchoolContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureSchoolTable(modelBuilder);
            ConfigureSchoolFileTable(modelBuilder);
        }


        private static void ConfigureSchoolTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolDto>(entity =>
            {
                entity.ToTable("schools");

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

                entity.Property(e => e.Location)
                    .HasColumnName("location");
                
                entity.Property(e => e.Info)
                    .HasColumnName("info");
                
                entity.Property(e => e.ShortInfo)
                    .HasColumnName("short_info");
                
                entity.HasIndex(e => e.SysName)
                    .IsUnique();
                
                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("course_file_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }

        private static void ConfigureSchoolFileTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolFileDto>(entity =>
            {
                entity.ToTable("school_files");

                entity.HasKey(e => new {e.SchoolId, e.FileId});

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("school_id");

                entity.HasOne(e => e.File)
                    .WithMany()
                    .HasForeignKey(e => e.FileId)
                    .HasConstraintName("school_files_file_fk")
                    .OnDelete(DeleteBehavior.Cascade);
                
                entity.HasOne(e => e.School)
                    .WithMany()
                    .HasForeignKey(e => e.SchoolId)
                    .HasConstraintName("school_files_school_fk")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}