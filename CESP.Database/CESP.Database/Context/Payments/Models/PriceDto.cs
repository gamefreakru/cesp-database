using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Context.Payments.Models
{
    public class PriceDto
    {
        public int Id  { get; set; }
        public decimal Cost { get; set; }
        public decimal? CostFull { get; set; }

        public string CostInfo { get; set; }
        public int? DiscountPer { get; set; }
        public string DiscountInfo { get; set; }

        public string PaymentPeriod { get; set; }
        
        public int? CurrencyId { get; set; }
        public CurrencyDto Currency { get; set; }
        
        public int StudentGroupId { get; set; }
        public StudentGroupDto Group { get; set; }

    }
}