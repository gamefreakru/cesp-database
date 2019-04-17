using System;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Users.Models
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public DateTime Date { get; set; }

        public string Signature { get; set; }

        public int? SourceId { get; set; }
        public FeedbackSourceDto Source { get; set; }

        public int? UserId { get; set; }
        public UserDto User { get; set; }

        public int? PhotoId { get; set; }
        
        public FileDto Photo { get; set; }

    }
}