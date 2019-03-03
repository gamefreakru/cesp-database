namespace CESP.Database.Context.Users.Models
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }

        public UserDto User { get; set; }
    }
}