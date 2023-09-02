using LoyaltyFAQChatbot.DTOs;
using LoyaltyFAQChatbot.Models;

namespace LoyaltyFAQChatbot.Services
{
    public interface IUserService
    {
        Task<User> GetUserInfoAsync(string mobileNumber);
    }
}
