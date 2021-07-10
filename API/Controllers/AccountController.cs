

using Domain.Authentication;
using Domain.IRepository;

using GloboTicket.TicketManagement.Application.Models.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private  readonly IAuthenticationRepository _authenticationRepository;
        public AccountController(IAuthenticationRepository authenticationRepository)
        {

            _authenticationRepository = authenticationRepository;
        }

        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _authenticationRepository.AuthenticateAsync(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync(RegistrationRequest request)
        {
            return Ok(await _authenticationRepository.RegisterAsync(request));
        }
    }
}
