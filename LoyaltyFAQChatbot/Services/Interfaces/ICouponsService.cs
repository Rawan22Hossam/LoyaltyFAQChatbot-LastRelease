using LoyaltyFAQChatbot.Models;

namespace LoyaltyFAQChatbot.Services
{
    public interface ICouponsService
    {
        Task<Coupons> CheckCoupon(int couponNumber, int userId);
    }
}
