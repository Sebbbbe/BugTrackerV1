using Domain.AuthenticationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Authentication.Command.Register
{
    public interface IRegistrationService
    {
        Task<RegistrationResponse> RegisterAsync(RegistrationCommand registrationCommand);
    }
}
