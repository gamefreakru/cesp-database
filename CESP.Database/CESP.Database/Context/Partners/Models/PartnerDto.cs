using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Partners.Models
{
    public class PartnerDto
    {
        public int Id { get; set; }
        
        public string SysName { get; set; }
        
        public string Name { get; set; }

        public string Url { get; set; }

        public string Info { get; set; }
        
        public string Email  { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string SocialNetwork { get; set; }

        public int? PhotoId { get; set; }
        public FileDto Photo { get; set; }
    }
}