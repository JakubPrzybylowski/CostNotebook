using costnotebook_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using costnotebook_backend.Models.Dto;
using costnotebook_backend.Repository;

namespace costnotebook_backend.Controllers
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly CostNotebookDbContext _context;
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;

        public TransactionController(CostNotebookDbContext context, IMapper mapper, IRepositoryManager repositoryManager)
        {
            _context = context;
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetTransactionForUser([FromQuery] int userId)
        {
            var user = _context.Users.First(x => x.UserID == userId);    

            if (user == null)
            {
                return BadRequest("Wrong user!");
            }

            var transactions = _repositoryManager.Transaction.FindByCondition(x => x.UserId == user.UserID,true);
            var respnse = _mapper.Map<List<TransactionDto>>(transactions);
            respnse.Reverse();
            return Ok(respnse);
        }

        [HttpGet("api/transactions/totalPositiveAmounts")]
        public IActionResult GetTotalPositiveAmountTransactionsForMonths()
        {
            var response = _repositoryManager.Transaction.GetTotalPositiveAmountTransactionsForMonths();
            return Ok(response);
        }

        [HttpGet("api/transactions/totalNegativeAmounts")]
        public IActionResult GetTotalNegativeAmountTransactionsForMonths()
        {
            var response = _repositoryManager.Transaction.GetTotalNegativeAmountTransactionsForMonths();
            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateTransaction([FromBody] TransactionDto transactionDto, [FromQuery] int userId)
        {
            var user = _context.Users.First(x => x.UserID == userId);
            if (user == null)
            {
                return BadRequest("Wrong user!");
            }
            var transaction = _mapper.Map<Transaction>(transactionDto);
            transaction.UserId = userId;
            _repositoryManager.Transaction.Create(transaction);
            _repositoryManager.Save();
            return Ok("Trasaction added to database");
        }
    }
}
