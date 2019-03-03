using CESP.Database.Context.Payments.Models;

namespace CESP.Database.Context.Education.Models
{
    public class StudentGroupPriceDto
    {
        public int Id { get; set; }
        
        public int StudentGroupId { get; set; }
        public StudentGroupDto StudentGroup { get; set; }
        
        public int PriceId { get; set; }
        public PriceDto Price { get; set; }
    }
}