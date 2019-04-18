using CESP.Database.Context.Payments.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Payments
{
    public class CurrencySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyDto>()
                .HasData(new CurrencyDto
                {
                    Id = (int)CurrencyEnum.Rub,
                    Name = "руб.",
                });
        }
    }
}