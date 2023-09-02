using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;

namespace LoyaltyFAQChatbot.Services
{
    public class TicketService : ITicketServcie
    {
        private readonly IGenericRepository<SupportTicket> _ticketRepo;

        public TicketService(IGenericRepository<SupportTicket> ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }
        public  int AddTicket(int userId, string mobileNumber, string ticketDescription)
        {
            SupportTicket ticket = new SupportTicket() { userId = userId, mobileNumber = mobileNumber, ticketDescription = ticketDescription, creationDate = DateTime.UtcNow , isSolved = false };
            _ticketRepo.Add(ticket);
            _ticketRepo.SaveChanges();
            return ticket.ticketId;
        }

        public async Task<SupportTicket> CheckTicket(int ticketId)
        {
            var check = _ticketRepo.Get(a => a.ticketId == ticketId);
            return check;
        }
    }
}
