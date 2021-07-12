
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectCommand : IRequest<CreateProjectResponse>
    {


        public string Project_Name { get; set; }



    }
}
