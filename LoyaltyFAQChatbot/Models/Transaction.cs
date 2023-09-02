namespace LoyaltyFAQChatbot.Models
{
    public class Transaction
    {
        public int transactionId { get; set; }
        public int userId { get; set; }
        public DateTime transactionDate { get; set; }
        public string transactionPoints { get; set; }
        public string transactionType { get; set; }
        public string transactionDescription { get; set; }
    }
}
