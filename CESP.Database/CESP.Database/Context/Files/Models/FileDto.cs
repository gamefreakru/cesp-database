using System.Collections.Generic;
using CESP.Database.Context.Education.Models;

namespace CESP.Database.Context.Files.Models
{
    public class FileDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }
        
        public int? FileType { get; set; }
        
        public ICollection<CourseFileDto> CourseFiles { get; set; }
    }
}