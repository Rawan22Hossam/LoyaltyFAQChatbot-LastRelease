namespace LoyaltyFAQChatbot.Models
{
    public class Answer
    { 
        public int answerId { get; set; }
        public int questionId { get; set; }
        public string answerText { get; set; }
        Question question { get; set; }
        Answer answer { get; set; }
        
    }
}
