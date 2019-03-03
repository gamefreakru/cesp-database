using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Models.Press
{
    public static class PressContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigurePressTable(modelBuilder);
        }

        private static void ConfigurePressTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.PressDto>(entity =>
            {
                entity.ToTable("presses");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Info)
                    .HasColumnName("info");

                entity.Property(e => e.BlogUrl)
                    .HasColumnName("blog_url");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(256);
                
                entity.Property(e => e.Date)
                    .HasColumnName("date");
            });
        }
    }
}