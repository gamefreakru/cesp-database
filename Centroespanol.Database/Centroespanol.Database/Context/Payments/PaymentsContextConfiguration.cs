using Centroespanol.Database.Context.Models;
using Centroespanol.Database.Context.Payments.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Payments
{
    public static class PaymentsContextConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            ConfigureCurrencyTable(modelBuilder);
            ConfigurePaymentPeriodTable(modelBuilder);
            ConfigurePrice(modelBuilder);
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

        private static void ConfigurePaymentPeriodTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentPeriodDto>(entity =>
            {
                entity.ToTable("payment_periods");

                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
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

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .IsRequired(false);

                entity.Property(e => e.DiscountPer)
                    .HasColumnName("discounter")
                    .IsRequired(false);
                
                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id");

                entity.HasOne(e => e.Currency)
                    .WithMany()
                    .HasForeignKey(e => e.CurrencyId)
                    .HasConstraintName("price_currency_fk")
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.PaymentPeriodId)
                    .HasColumnName("payment_period_id");
                
                entity.HasOne(e => e.PaymentPeriod)
                    .WithMany()
                    .HasForeignKey(e => e.PaymentPeriodId)
                    .HasConstraintName("price_payment_period_fk")
                    .OnDelete(DeleteBehavior.Cascade);

            });
        }
    }
}