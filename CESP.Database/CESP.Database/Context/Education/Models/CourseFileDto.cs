using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Education.Models
{
    public class CourseFileDto
    {
        public int CourseId { get; set; }
        
        public int FileId { get; set; }

        public CourseDto Course { get; set; }

        public FileDto File { get; set; }
    }
}