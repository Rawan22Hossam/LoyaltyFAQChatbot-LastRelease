using LoyaltyFAQChatbot.DTOs;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyFAQChatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

            public UserController(IUserService userService)
            {
                 _userService = userService;
            }
        [HttpGet("GetMobileNumberInfo")]
        public async Task<ActionResult> GetUserInfoAsync(string mobileNumber)
        {
            var result = await _userService.GetUserInfoAsync(mobileNumber);
            if (result == null)
                return BadRequest("Invalid Mobile Number");
            return Ok(result);
        }
    }
}
