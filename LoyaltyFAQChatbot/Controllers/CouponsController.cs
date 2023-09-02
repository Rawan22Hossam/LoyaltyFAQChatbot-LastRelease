using LoyaltyFAQChatbot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyFAQChatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {    
        private readonly ICouponsService _couponsService;
        public CouponsController(ICouponsService couponsService)
        {
            _couponsService = couponsService;
        }
        [HttpGet("CheckCoupons")]
        public async Task<ActionResult> CheckCoupons(int couponNumber, int userId) 
        {
            var result = await _couponsService.CheckCoupon(couponNumber, userId);
           
            if (result == null)
                return BadRequest("Invalid Coupon Number");
            else if (result.expiryDate < DateTime.UtcNow)
                return BadRequest("Coupon Number Expired");
            else if (result.couponStatus.ToLower() == "burned")
                return BadRequest("Coupon Number used before");
            return Ok(result);

        
        }
    }
}
