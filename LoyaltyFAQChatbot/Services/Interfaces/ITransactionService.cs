using LoyaltyFAQChatbot.Models;

namespace LoyaltyFAQChatbot.Services
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetTransaction(int userId);
    }
}
