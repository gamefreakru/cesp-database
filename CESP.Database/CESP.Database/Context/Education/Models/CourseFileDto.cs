using System.ComponentModel.DataAnnotations.Schema;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Education.Models
{
    [Table("course_files")]
    public class CourseFileDto
    {
        [Column("course_id")]
        public int CourseId { get; set; }
        
        [Column("file_id")]
        public int FileId { get; set; }

        [Column("priority")]
        public int? Priority { get; set; }

        public CourseDto Course { get; set; }

        public FileDto File { get; set; }
    }
}