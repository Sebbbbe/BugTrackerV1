using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Domain.AuthenticationModels;
using System;
using System.Threading.Tasks;

namespace Application.Features.Authentication.Command.Register
{
    public class RegistrationHandler : IRegistrationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        public RegistrationHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<RegistrationResponse> RegisterAsync(RegistrationCommand request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.UserName);

            if (existingUser != null)
            {
                throw new Exception($"Username '{request.UserName}' already exists.");
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                EmailConfirmed = true
            };

            var existingEmail = await _userManager.FindByEmailAsync(request.Email);

            if (existingEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);

                if (result.Succeeded)
                {
                    var registrationModel = new RegistrationModel() { ApplicationUserId = user.Id };

                    var registrationResponse = _mapper.Map<RegistrationResponse>(registrationModel);

                    return registrationResponse;
                }
                else
                {
                    throw new Exception($"{result.Errors}");
                }
            }
            else
            {
                throw new Exception($"Email {request.Email } already exists.");
            }
        }



    }
}
