using costnotebook_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using costnotebook_backend.Models.Dto;

namespace costnotebook_backend.Controllers
{
    [Route("api/transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private CostNotebookDbContext _context;
        private IMapper _mapper;

        public TransactionController(CostNotebookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/transactions/{userId}")]
        [Authorize]
        public IActionResult GetTransactionForUser([FromRoute] int userId)
        {
            var user = _context.Users.First(x => x.UserID == userId);
            if (user == null)
            {
                return BadRequest("Wrong user!");
            }
            var transactions = _context.Transactions.ToList();
            var respnse = _mapper.Map<List<TransactionDto>>(transactions);
            return Ok(respnse);
        }
    }
}
