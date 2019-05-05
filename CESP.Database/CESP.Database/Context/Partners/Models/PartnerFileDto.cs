using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Partners.Models
{
    public class PartnerFileDto
    {
        public int PartnerId { get; set; }
        
        public int FileId { get; set; }

        public PartnerDto Partner { get; set; }

        public FileDto File { get; set; }
    }
}