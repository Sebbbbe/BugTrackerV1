
using Application.Features.Authentication.Command.Register;
using Application.Features.Authentication.Commands.Login;
using Application.Features.Issues.Command.CreateIssue;
using Application.Features.Issues.Query;
using Application.Features.Projects.Command.CreateProject;
using AutoMapper;
using Domain.AuthenticationModels;
using Domain.Models;

namespace Application.Services
{
    public class MappingProfile : Profile
    {
       
        public MappingProfile()
        {


            //from model to CreateModelResponse
            CreateMap<Issue, CreateIssueResponse>();
            CreateMap<Project, CreateProjectResponse>();






            //from model to GetModelResponse
            CreateMap<Issue, GetAllIssuesResponse>();




            //authentication
            CreateMap<RegistrationModel, RegistrationResponse>();
            CreateMap<AuthenticationModel, AuthenticationResponse>();




        }

   
        
    }
}
