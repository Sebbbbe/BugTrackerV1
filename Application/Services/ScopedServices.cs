

using Application.Features.Authentication.Command.Register;
using Application.Features.Issues.Query;

using Domain.IRepository;
using Infrastructure;
using Infrastructure.Repository;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public static class ScopedServices
    {
        public static IServiceCollection AddScopeService(this IServiceCollection services, IConfiguration configuration)
        { 
         

          
       
            
            
            //infrastructure to repository
            
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));


            //For IRepositories to Repositories
            services.AddScoped<IIssueRepository ,  IssueRepository> ();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();




            //authentication
        

            services.AddScoped<IRegistrationService, RegistrationHandler>();

            // service to handler

            services.AddScoped<IGetAllIssuesService, GetAllIssuesHandler>();






            services.AddIdentityServices(configuration);










            return services;


        }
    }
}
