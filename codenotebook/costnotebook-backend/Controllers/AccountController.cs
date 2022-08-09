using costnotebook_backend.Models;
using costnotebook_backend.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace costnotebook_backend.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly CostNotebookDbContext _context;

        public AccountController(CostNotebookDbContext context)
        {  
            _context = context;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            //if (userForRegistration == null || !ModelState.IsValid)
            //    return BadRequest();

            //var user = _mapper.Map<User>(userForRegistration);
            //var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            //if (!result.Succeeded)
            //{
            //    var errors = result.Errors.Select(e => e.Description);

            //    return BadRequest(new RegistrationResponseDto { Errors = errors });
            //}

            return StatusCode(201);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user is null)
            {
                return BadRequest("Invalid user request!!!");
            }
            var users = _context.Users.ToList();
            var isCorrectUser = users.Where(x => x.UserEmail == user.UserName && x.Password == user.Password).ToList().Any();
            if (isCorrectUser)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSetting["JWTSettings:Secret"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: ConfigurationManager.AppSetting["JWTSettings:ValidIssuer"],
                    audience: ConfigurationManager.AppSetting["JWTSettings:ValidAudience"],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(6), 
                    signingCredentials: signinCredentials
                    );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new AuthResponseDto
                {
                    Token = tokenString
                });
            }
            return Unauthorized();
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetUsers()
        {
            return Ok(_context.Users.ToList());
        }
    }
}
