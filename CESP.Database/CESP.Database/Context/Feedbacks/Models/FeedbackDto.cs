using System;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Feedbacks.Models
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public DateTime Date { get; set; }

        public int? SourceId { get; set; }
        public FeedbackSourceDto Source { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? PhotoId { get; set; }
        
        public FileDto Photo { get; set; }

    }
}