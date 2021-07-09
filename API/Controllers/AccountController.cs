

using Application.Features.Authentication.Command.Register;
using Domain.AuthenticationModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        public AccountController(IRegistrationService registrationService)
        {
    
            _registrationService = registrationService;
        }

        //[HttpPost("authenticate")]
        //public async Task<ActionResult<AuthenticationModel>> AuthenticateAsync(AuthenticationRequest request)
        //{
        //    return Ok(await _authenticationService.AuthenticateAsync(request));
        //}

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync(RegistrationCommand request)
        {
            return Ok(await _registrationService.RegisterAsync(request));
        }
    }
}
