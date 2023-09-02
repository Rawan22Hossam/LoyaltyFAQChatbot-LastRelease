/*using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyFAQChatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AnswerController : ControllerBase
    {
            private readonly IAnswerService _answerService;

            public AnswerController(IAnswerService answerService)
            {
            _answerService = answerService;
            }
     
        [HttpGet("GetAnswer")]
        public async Task<ActionResult> GetAnswerAsync()
        {
            var result = _answerService.GetAnswerAsync();
            if (result == null)
                return BadRequest();
            return Ok(result);
        }
     
    }
}
*/