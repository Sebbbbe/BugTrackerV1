

using Application.Features.Authentication.Command.Register;
using Application.Features.Authentication.Commands.Login;
using Domain.AuthenticationModels;
using Features.Authentication.Commands.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IRegistrationService registrationService, IAuthenticationService authenticationService)
        {
    
            _registrationService = registrationService;
            _authenticationService = authenticationService;
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


        [HttpPost("login")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateAsync(AuthenticationCommand request)
        {
            return Ok(await _authenticationService.AuthenticateAsync(request));
        }
    }

}
