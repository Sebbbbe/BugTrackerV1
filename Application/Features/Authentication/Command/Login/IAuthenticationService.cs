using Features.Authentication.Commands.Login;
using System.Threading.Tasks;

namespace Application.Features.Authentication.Commands.Login
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationCommand request);
    }
}
