
using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;

namespace LoyaltyFAQChatbot.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepo;
       
        public UserService(IGenericRepository<User> userRepo)
        {
            _userRepo = userRepo;
           
        }
        public async Task<User> GetUserInfoAsync(string mobileNumber)
        {
            var userInfo = _userRepo.Get(a => a.mobileNumber == mobileNumber);
            return userInfo;
        }
    }
}
