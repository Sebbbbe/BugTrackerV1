using AutoMapper;
using Domain.AuthenticationModels;
using Domain.IRepository;
using Features.Authentication.Commands.Login;
using Microsoft.AspNetCore.Identity;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace Application.Features.Authentication.Commands.Login
{
    public class AuthenticationHandler : IAuthenticationService
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly IMapper _mapper;
        private readonly IAuthenticationRepository _authenticationRepository;


        public AuthenticationHandler(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper,
            IAuthenticationRepository authenticationRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _authenticationRepository = authenticationRepository;
        }
        public async Task<AuthenticationResponse> AuthenticateAsync(AuthenticationCommand request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new Exception($"User with {request.Email} not found.");
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                throw new Exception($"Credentials for '{request.Email} aren't valid'.");
            }

            JwtSecurityToken jwtSecurityToken = await _authenticationRepository.GenerateToken(user);

            var authenticationModel = new AuthenticationModel
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Email = user.Email,
                UserName = user.UserName
            };

            var authenticationResponse = _mapper.Map<AuthenticationResponse>(authenticationModel);

            return authenticationResponse;
        }
    }
}
