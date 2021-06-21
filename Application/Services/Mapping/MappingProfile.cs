using Application.Features.Command.Issues.CreateIssue;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class MappingProfile : Profile
    {
       
        public MappingProfile()
        {


            //issue
            CreateMap<CreateIssueHandler, CreateIssueResponse>();
        }

   
        
    }
}
