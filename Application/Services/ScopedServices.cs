
using Application.Features.Issues.Query;

using Domain.IRepository;
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
           
           



            //authentication
            

            // service to handler

            services.AddScoped<IGetAllIssuesService, GetAllIssuesHandler>();
            //services.AddScoped<IRegistrationService, RegistrationHandler>();


         




            //services.AddScoped<IAuthenticationService, AuthenticationService>();

            // AuthenticationService

            //services.AddScoped<IAuthenticationService, AuthenticationService>();








            return services;


        }
    }
}
