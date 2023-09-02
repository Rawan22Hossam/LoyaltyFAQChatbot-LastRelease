using LoyaltyFAQChatbot.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyFAQChatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpGet("GetTransactions")] 
        public async Task<ActionResult> GetTransactions(int userId)
        {
            var result = await _transactionService.GetTransaction(userId);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
