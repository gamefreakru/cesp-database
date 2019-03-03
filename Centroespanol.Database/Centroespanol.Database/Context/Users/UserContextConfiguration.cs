using System.Security.Cryptography.X509Certificates;
using Centroespanol.Database.Context.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Users
{
    public static class UserContextConfiguration
    {

        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureUserTable(modelBuilder);
            ConfigureFeedbackTable(modelBuilder);
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

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(256);
            });
        }

        private static void ConfigureFeedbackTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackDto>(entity =>
            {
                entity.ToTable("feedbacks");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsRequired();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id");

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey("feedback_user_fk")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}