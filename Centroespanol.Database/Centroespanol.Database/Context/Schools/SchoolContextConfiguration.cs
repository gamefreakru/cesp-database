using Centroespanol.Database.Context.Schools.Models.Schools;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Models.Schools
{
    public static class SchoolContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureSchoolTable(modelBuilder);
        }


        private static void ConfigureSchoolTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolDto>(entity =>
            {
                entity.ToTable("schools");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

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
            });
        }
    }
}