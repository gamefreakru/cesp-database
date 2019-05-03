using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Activities.Models
{
    public class ActivityFilesDto
    {
        public int ActivityId { get; set; }

        public ActivityDto Activity { get; set; }

        public int FileId { get; set; }

        public FileDto File { get; set; }
    }
}