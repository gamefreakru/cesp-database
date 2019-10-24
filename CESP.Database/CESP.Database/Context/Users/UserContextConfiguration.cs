using CESP.Database.Context.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Users
{
    public static class UserContextConfiguration
    {

        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureUserTable(modelBuilder);
        }

        private static void ConfigureUserTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDto>(entity =>
            {
                entity.ToTable("users");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(256)
                    .IsRequired();
                
                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .IsRequired()
                    .HasDefaultValueSql("now()");
                
                entity.HasIndex(e => e.Contact)
                    .IsUnique();
            });
        }
    }
}