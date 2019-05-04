using CESP.Database.Context.Payments.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Payments
{
    public static class PaymentsContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureCurrencyTable(modelBuilder);
            ConfigurePrice(modelBuilder);
            
            CurrencySeed.Seed(modelBuilder);
        }
        
        private static void ConfigureCurrencyTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyDto>(entity =>
            {
                entity.ToTable("currencies");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsRequired();
            });
        }


        private static void ConfigurePrice(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceDto>(entity =>
            {
                entity.ToTable("prices");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");
                
                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .IsRequired();

                entity.Property(e => e.CostInfo)
                    .HasColumnName("cost_info")
                    .HasMaxLength(256);

                entity.Property(e => e.DiscountInfo)
                    .HasColumnName("discount_info")
                    .HasMaxLength(256);

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("discounter")
                    .IsRequired(false);

                entity.Property(e => e.PaymentPeriod)
                    .HasColumnName("payment_period")
                    .IsRequired(false)
                    .HasMaxLength(256);

                entity.Property(e => e.StudentGroupId)
                    .HasColumnName("group_id");
                entity.HasOne(e => e.Group)
                    .WithMany()
                    .HasForeignKey(e => e.StudentGroupId)
                    .HasConstraintName("price_student_group_fk")
                    .OnDelete(DeleteBehavior.Cascade);
 
                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .IsRequired(false);

                entity.HasOne(e => e.Currency)
                    .WithMany()
                    .HasForeignKey(e => e.CurrencyId)
                    .HasConstraintName("price_currency_fk")
                    .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}