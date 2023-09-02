using LoyaltyFAQChatbot.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace LoyaltyFAQChatbot.Controllers
{
    public class TicketController : ControllerBase
    {
        private readonly ITicketServcie _ticketServcie;
        public TicketController(ITicketServcie ticketServcie)
        {
            _ticketServcie = ticketServcie;
        }
        [HttpPost("AddTicket")]
        public  int AddTicket(int userId, string mobileNumber, string ticketDescription)
        {
            var result = _ticketServcie.AddTicket(userId, mobileNumber, ticketDescription);
            return result;
        }
        [HttpGet("CheckTicket")]
        public async Task<ActionResult> CheckTicket(int ticketId)
        {
            var result = await _ticketServcie.CheckTicket(ticketId);
            if (result == null)
                return BadRequest("Invalid Ticket Id");
            return Ok(result);
        }

    }
}
