using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Partners
{
    public class PartnerContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigurePartnerTable(modelBuilder);
            ConfigurePartnerFileTable(modelBuilder);
        }

        private static void ConfigurePartnerTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.PartnerDto>(entity =>
            {
                entity.ToTable("partners");
                
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.SysName)
                    .HasColumnName("sysname")
                    .IsRequired()
                    .HasMaxLength(256);
                    
                entity.HasIndex(e => e.SysName)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Info)
                    .HasColumnName("info");
                
                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256);
                
                entity.Property(e => e.Address)
                    .HasColumnName("address");
                
                entity.Property(e => e.Phone)
                    .HasColumnName("phone");
                
                entity.Property(e => e.SocialNetwork)
                    .HasColumnName("socnet");
                
                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(256);
                
                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .IsRequired(false);

                entity.HasOne(e => e.Photo)
                    .WithMany()
                    .HasForeignKey(e => e.PhotoId)
                    .HasConstraintName("partner_file_fk")
                    .OnDelete(DeleteBehavior.SetNull);
                
            });
        }

        private static void ConfigurePartnerFileTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.PartnerFileDto>(entity =>
            {
                entity.ToTable("partner_files");
                
                entity.HasKey(e => new { e.FileId, e.PartnerId});
                
                entity.Property(e => e.PartnerId)
                    .HasColumnName("partner_id")
                    .IsRequired();
                entity.HasOne(e => e.Partner)
                    .WithMany()
                    .HasForeignKey(e => e.PartnerId)
                    .HasConstraintName("partner_file_partner_fk")
                    .OnDelete(DeleteBehavior.Cascade);
                
                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .IsRequired();
                entity.HasOne(e => e.File)
                    .WithMany()
                    .HasForeignKey(e => e.FileId)
                    .HasConstraintName("partner_file_file_fk")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}