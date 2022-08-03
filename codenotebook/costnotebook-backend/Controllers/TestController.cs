using costnotebook_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace costnotebook_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly CostNotebookDbContext _context;

        public TestController(CostNotebookDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetTest()
        {
            var tests = _context.Tests.ToList();
            return Ok(tests);
        }
    }
}
