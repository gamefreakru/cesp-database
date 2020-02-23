using CESP.Database.Context.Files.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Files
{
    public static class FilesContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureFileTable(modelBuilder);
        }

        private static void ConfigureFileTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileDto>(entity =>
            {
                entity.ToTable("files");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .IsRequired();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();

                entity.Property(e => e.Info)
                    .HasColumnName("info");
                
                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .IsRequired(false);
            });
        }
    }
}