using Application.Features.Authentication.Command.Register;
using Application.Features.Authentication.Commands.Login;
using Application.Features.Command.Issues.CreateIssue;
using Application.Features.Issues.Query;
using AutoMapper;
using Domain.AuthenticationModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class MappingProfile : Profile
    {
       
        public MappingProfile()
        {


            //from model to CreateModelResponse
            CreateMap<Issue, CreateIssueResponse>();
          
            
            
            

            //from model to GetModelResponse
            CreateMap<Issue, GetAllIssuesResponse>();




            //authentication
            CreateMap<RegistrationModel, RegistrationResponse>();
            CreateMap<AuthenticationModel, AuthenticationResponse>();




        }

   
        
    }
}
