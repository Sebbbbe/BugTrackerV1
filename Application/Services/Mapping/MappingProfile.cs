<<<<<<< HEAD
﻿using Application.Features.Command.Issues.CreateIssue;
=======
﻿using Application.Features.Authentication.Command.Register;
using Application.Features.Authentication.Commands.Login;
using Application.Features.Command.Issues.CreateIssue;
>>>>>>> e47bbdd ( added register login authentication)
using Application.Features.Issues.Query;
using AutoMapper;
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


<<<<<<< HEAD
=======


            //authentication
            CreateMap<RegistrationModel, RegistrationResponse>();
            CreateMap<AuthenticationModel, AuthenticationResponse>();


>>>>>>> e47bbdd ( added register login authentication)


        }

   
        
    }
}
