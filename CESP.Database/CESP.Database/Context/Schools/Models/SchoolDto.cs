using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Schools.Models
{
    public class SchoolDto
    {
        public int Id { get; set; }
        
        public string SysName { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ShortInfo { get; set; }
        public string Info { get; set; }

        public int PhotoId { get; set; }

        public FileDto Photo { get; set; }
    }
}