using costnotebook_backend.Models;
using costnotebook_backend.Models.Dto;
using costnotebook_backend.Repository;
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
        private readonly IRepositoryManager _repositoryManager;

        public AccountController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
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
        public IActionResult Login([FromBody] Login login)
        {
            var user = _repositoryManager.User.FindByCondition(x => x.UserEmail == login.UserName, true).FirstOrDefault();
            if (user != null)
            {
                var result = _repositoryManager.Account.GetJwt(user);
                return Ok(new AuthResponseDto
                {
                    IsAuthSuccessful = true,
                    Token = result
                });
            }
            return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
        }
    }
}
