using LoyaltyFAQChatbot.GenericRepository;
using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoyaltyFAQChatbot.Services
{
    public class CouponsService : ICouponsService
    {
        private readonly IGenericRepository<Coupons> _couponRepo;

        public CouponsService(IGenericRepository<Coupons> couponRepo)
        {
            _couponRepo = couponRepo;
        }
        public async Task<Coupons> CheckCoupon(int couponNumber, int userId) 
        {
            
            var coupon = _couponRepo.Get(a => a.userId == userId && a.couponNumber == couponNumber);
            return coupon;
        }
    }
}
