
using Domain.AuthenticationModels;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;


namespace Domain.IRepository
{
    public interface IAuthenticationService
    {


        Task<JwtSecurityToken> GenerateToken(ApplicationUser user);
    }
}
