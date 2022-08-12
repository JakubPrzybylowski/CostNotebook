using costnotebook_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using costnotebook_backend.Models.Dto;
using costnotebook_backend.Repository;

namespace costnotebook_backend.Controllers
{
    [Route("api/transaction")]
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

        [HttpGet("/transactions/{userId}")]
        [Authorize]
        public IActionResult GetTransactionForUser([FromRoute] int userId)
        {
            var user = _context.Users.First(x => x.UserID == userId);
            if (user == null)
            {
                return BadRequest("Wrong user!");
            }

            var transactions = _repositoryManager.Transaction.FindByCondition(x => x.UserId == userId,true);
            var respnse = _mapper.Map<List<TransactionDto>>(transactions);
            return Ok(respnse);
        }
    }
}
