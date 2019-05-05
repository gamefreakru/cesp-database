using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Schools.Models
{
    public class SchoolFileDto
    {
        public int SchoolId { get; set; }

        public int FileId { get; set; }

        public SchoolDto School { get; set; }

        public FileDto File { get; set; }
    }
}