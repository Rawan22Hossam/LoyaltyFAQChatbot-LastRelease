using AutoMapper;
using LoyaltyFAQChatbot.DTOs;
using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;

namespace LoyaltyFAQChatbot.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IGenericRepository<Question> _questionRepo;
        private readonly IMapper _mapper;
        public QuestionService(IGenericRepository<Question> questionRepo)
        {
            _questionRepo = questionRepo;
           
        }

       
        public async Task<string> AddQuestionAsync(string questionText, int userId)
        {
            var question = new Question() { questionText = questionText, userId = userId , creationDate = DateTime.UtcNow }; 
           // var questionDb = _questionRepo.GetAll().Where(a => a.questionText == questionText).FirstOrDefault();
            var addQuestion = _questionRepo.Add(question);
            _questionRepo.SaveChanges();
            return "";

        }
        
    }
}