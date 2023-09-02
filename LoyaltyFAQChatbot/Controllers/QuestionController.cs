using LoyaltyFAQChatbot.DTOs;
using LoyaltyFAQChatbot.Models;
using LoyaltyFAQChatbot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyFAQChatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class QuestionController : ControllerBase
    {
            private readonly IQuestionService _questionService;

            public QuestionController(IQuestionService questionService)
            {
            _questionService = questionService;
            }
 
        [HttpPost("InsertQuestion")]
        public async Task<ActionResult> AddQuestionAsync(string questionText, int userId)
        {
            var result = await _questionService.AddQuestionAsync(questionText,userId);
            
            return Ok(result);
        }
 
    }
}
