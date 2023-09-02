using LoyaltyFAQChatbot.Models;

namespace LoyaltyFAQChatbot.Services
{
    public interface ITicketServcie
    {
        int AddTicket(int userId, string mobileNumber, string ticketDescription);
        Task<SupportTicket> CheckTicket(int ticketId);
    }
}
