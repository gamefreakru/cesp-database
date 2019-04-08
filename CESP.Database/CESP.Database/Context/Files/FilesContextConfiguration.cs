using CESP.Database.Context.Files.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Files
{
    public static class FilesContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureFileTable(modelBuilder);
            
            FilesSeed.Seed(modelBuilder);
        }

        private static void ConfigureFileTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileDto>(entity =>
            {
                entity.ToTable("files");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.Info)
                    .HasColumnName("info");
            });
        }
    }
}