using Application.Binds;
using Application.Features.Command.Issues.CreateIssue;
using Application.Services;
using AutoMapper;
using Domain.IRepository;

using Identity;
using Identity.Models;
using Infrastructure;
using Infrastructure.Repository;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace API
{
    public class Startup
    {
        readonly string MyPolicy = "MyPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddCors(options =>
            {
                options.AddPolicy(name: MyPolicy,
                    builder =>
                    {
                        builder.WithOrigins(
                              "http://localhost:44321",
                            "http://localhost:44322"
                          )
                        .AllowAnyMethod().AllowAnyHeader();
                    });
            });
            services.AddControllers();



            //context
            services.AddDbContext<Infrastructure.BugTrackerContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));





            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                      }
                    });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BugTracker", Version = "v1" });
            });

            services.AddIdentityServices(Configuration);
            services.AddScopeService(Configuration);

            services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<BugTrackerContext2>().AddDefaultTokenProviders();


            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddOptions();
            services.AddMediatR(typeof(BugTrackerMediatREntryPoint).Assembly);



        


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors();
            }
          

            app.UseHttpsRedirection();
           

            app.UseRouting();

           
            app.UseAuthentication();
            app.UseAuthorization();
   


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BugTracker");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
