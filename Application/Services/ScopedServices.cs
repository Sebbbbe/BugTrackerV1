

using Application.Features.Authentication.Command.Register;
using Application.Features.Authentication.Commands.Login;
using Application.Features.Issues.Query;

using Domain.IRepository;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Features.Authentication.Commands.Login;


namespace Application.Services
{
    public static class ScopedServices
    {
        public static IServiceCollection AddScopeService(this IServiceCollection services, IConfiguration configuration)
        { 
         

          
       
            
            
            //infrastructure to repository
            
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();


            //For IRepositories to Repositories
            services.AddScoped<IIssueRepository ,  IssueRepository> ();




            //authentication


            services.AddScoped<IRegistrationService, RegistrationHandler>();
            services.AddScoped<Features.Authentication.Commands.Login.IAuthenticationService, AuthenticationHandler>();
            services.AddScoped<Features.Authentication.Commands.Login.IAuthenticationService, AuthenticationHandler>();



            // service to handler

            services.AddScoped<IGetAllIssuesService, GetAllIssuesHandler>();






            services.AddIdentityServices(configuration);










            return services;


        }
    }
}
