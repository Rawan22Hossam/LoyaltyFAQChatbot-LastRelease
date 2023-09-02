namespace LoyaltyFAQChatbot.Models
{
    public class SupportTicket
    {
        public int ticketId { get; set; }
        public int userId { get; set; }
        public string mobileNumber { get; set; }
        
        public DateTime creationDate { get; set; }
        public bool isSolved { get; set; }
        public string ticketDescription { get; set;}
        
    }
}
