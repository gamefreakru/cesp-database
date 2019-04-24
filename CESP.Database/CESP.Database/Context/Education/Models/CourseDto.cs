using System.Collections.Generic;
using CESP.Database.Context.Files.Models;
using CESP.Database.Context.Payments.Models;

namespace CESP.Database.Context.Education.Models
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string DurationInfo { get; set; }
        
        public int? PhotoId { get; set; }
        public FileDto Photo { get; set; }
    }
}