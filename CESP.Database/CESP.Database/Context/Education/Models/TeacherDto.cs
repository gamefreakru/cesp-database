using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Education.Models
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }

        public string Info { get; set; }
        
        public int? PhotoId { get; set; }

        public FileDto Photo { get; set; }
    }
}