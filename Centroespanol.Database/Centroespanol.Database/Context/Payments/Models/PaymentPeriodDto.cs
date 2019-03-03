namespace Centroespanol.Database.Context.Payments.Models
{
    public class PaymentPeriodDto
    {
        public int Id { get; set; }
        // week, 2 week, half of course etc
        public string Info { get; set; }
    }
}