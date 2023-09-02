namespace LoyaltyFAQChatbot.Models
{
    public class Coupons
    {
        public int couponId { set; get; }
        public int couponNumber { set; get; } 
        public int userId { set; get; }
        public string mobileNumber { set; get; }
        public DateTime expiryDate { set; get; }
        public int couponValue { set; get; }
        public string couponStatus { set; get; }
        User User { set; get; }
    }
}
