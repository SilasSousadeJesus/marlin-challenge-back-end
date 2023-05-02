namespace marlin_challenge_back_end.Models
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
