namespace Centroespanol.Database.Context.Payments.Models
{
    public class PriceDto
    {
        public int Id  { get; set; }
        public decimal Cost { get; set; }
        public int? DiscountPer { get; set; }
        public decimal? Discount { get; set; }
        
        public int CurrencyId { get; set; }
        public CurrencyDto Currency { get; set; }
        
        public int PaymentPeriodId { get; set; }
        public PaymentPeriodDto PaymentPeriod { get; set; }
    }
}