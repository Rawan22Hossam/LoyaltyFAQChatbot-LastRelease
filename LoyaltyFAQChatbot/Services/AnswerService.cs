
using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;


namespace LoyaltyFAQChatbot.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IGenericRepository<Answer> _answerRepo;
        
        public AnswerService(IGenericRepository<Answer> answerRepo)
        {
            _answerRepo = answerRepo;
           
        }
        
      /*  public async Task<Answer> GetAnswerAsync(int questionId)
        {
            var answer = _answerRepo.GetAll(answerText).ToList();
            return answer ;
        }

       */
    }
}
