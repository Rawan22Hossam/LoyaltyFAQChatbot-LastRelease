namespace LoyaltyFAQChatbot.Models
{
    public class Question
    {
        public int questionId { get; set; }
        public int userId { get; set; }
        public string questionText { get; set; }
        public DateTime creationDate { get; set; }
        User user { get; set; }
    }
}
