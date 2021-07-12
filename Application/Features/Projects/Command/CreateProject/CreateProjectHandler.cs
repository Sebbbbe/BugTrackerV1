
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using AutoMapper;
using MediatR;
using System.Threading;
using Application.Validators;
using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel;
using Application.Features.Issues.Command.CreateIssue;
using System.Runtime.Intrinsics.X86;

namespace Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectHandler : IRequestHandler<CreateProjectCommand, CreateProjectResponse>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;


        public CreateProjectHandler(IProjectRepository projectRepository , IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
            
        }



        public async Task<CreateProjectResponse> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {


            var createProjectResponse = new CreateProjectResponse();

            var validator = new CreateProjectCommandValidation();

            var results = validator.Validate(request);



            if (results.IsValid == false)
            {
                createProjectResponse.Success = false;
                createProjectResponse.ValidationErrors = new List<string>();

                foreach (var error in results.Errors)
                {
                    createProjectResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }




            if (results.IsValid == true)
            {
                var project = new Project()
                {
                    Project_Name = request.Project_Name

                };
                await _projectRepository.AddAsync(project);
                createProjectResponse = _mapper.Map<CreateProjectResponse>(project);
            }



            return createProjectResponse;











        }
    }
}