using costnotebook_backend.Authorization;
using costnotebook_backend.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace costnotebook_backend.Repository
{
    public class AccountRepository : RepositoryBase<User>, IAccountRepository
    {
        public AccountRepository(CostNotebookDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public string GetJwt(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSetting["JWTSettings:Secret"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: ConfigurationManager.AppSetting["JWTSettings:ValidIssuer"],
                audience: ConfigurationManager.AppSetting["JWTSettings:ValidAudience"],
                claims: JwtHandler.GetClaims(user),
                expires: DateTime.Now.AddMinutes(6),
                signingCredentials: signinCredentials
                ); 
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }
    }
}
