using Domain.Authentication;
using GloboTicket.TicketManagement.Application.Models.Authentication;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IAuthenticationRepository
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
