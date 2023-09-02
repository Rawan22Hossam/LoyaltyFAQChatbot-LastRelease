using LoyaltyFAQChatbot.DTOs;
using LoyaltyFAQChatbot.Models;

namespace LoyaltyFAQChatbot.Services
{
    public interface IQuestionService
    {
        Task<string> AddQuestionAsync(string questionText, int userId);
    }
}
