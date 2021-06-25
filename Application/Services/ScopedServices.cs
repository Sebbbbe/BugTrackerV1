using Application.Features.Command.Issues.CreateIssue;
using Application.Features.Issues.Query;
using Domain.IRepository;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public static class ScopedServices
    {
        public static IServiceCollection AddScopeService(this IServiceCollection services, IConfiguration configuration)
        { 
         

          
            //mediatr

            
            
            //infrastructure to repository
            
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
           
            
            //Issue
            services.AddScoped<IIssueRepository ,  IssueRepository> ();




            // service to handler

            services.AddScoped<IGetAllIssuesService, GetAllIssuesHandler>();







            return services;


        }
    }
}
