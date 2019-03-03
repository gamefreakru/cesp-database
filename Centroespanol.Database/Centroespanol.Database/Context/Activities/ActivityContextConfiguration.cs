using Centroespanol.Database.Context.Activities.Models;
using Centroespanol.Database.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Activities
{
    public static class ActivityContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureActivityTable(modelBuilder);
        }

        private static void ConfigureActivityTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityDto>(entity =>
            {
                entity.ToTable("activities");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.ShortInfo)
                    .HasColumnName("short_info");

                entity.Property(e => e.Info)
                    .HasColumnName("info");

                entity.Property(e => e.Start)
                    .HasColumnName("start");

                entity.Property(e => e.End)
                    .HasColumnName("end");
            });
        }
        
        
    }
}