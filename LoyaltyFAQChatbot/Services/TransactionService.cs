using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;

namespace LoyaltyFAQChatbot.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IGenericRepository<Transaction> _transactionRepo;

        public TransactionService(IGenericRepository<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        public async Task<List<Transaction>> GetTransaction(int userId)
        {
            var result =  _transactionRepo.GetAll().Where(t => t.userId == userId).OrderByDescending(a => a.transactionDate).Take(5).ToList();
            return result;
                
        }
    }
}
