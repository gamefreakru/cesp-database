using CESP.Database.Context.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Users
{
    public static class UserContextConfiguration
    {

        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureFeedbackSourceTable(modelBuilder);
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

                entity.Property(e => e.Signature)
                    .HasColumnName("signature");

                entity.Property(e => e.Date)
                    .HasColumnName("date");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .IsRequired(false);
                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .HasConstraintName("feedback_user_fk")
                    .OnDelete(DeleteBehavior.SetNull);

                entity.Property(e => e.SourceId)
                    .HasColumnName("feedback_source_id")
                    .IsRequired(false);
                entity.HasOne(e => e.Source)
                    .WithMany()
                    .HasForeignKey(e => e.SourceId)
                    .HasConstraintName("feedback_source_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }

        private static void ConfigureFeedbackSourceTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackSourceDto>(entity =>
            {
                entity.ToTable("feedback_sources");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");
            });
        }
    }
}