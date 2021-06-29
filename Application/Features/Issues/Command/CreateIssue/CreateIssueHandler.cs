
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

namespace Application.Features.Command.Issues.CreateIssue
{
    public class CreateIssueHandler : IRequestHandler<CreateIssueCommand, CreateIssueResponse>
    {
        private readonly IIssueRepository _issueRepository;
        private readonly IMapper _mapper;


        public CreateIssueHandler(IIssueRepository issueRepository, IMapper mapper)
        {
            _issueRepository = issueRepository;
            _mapper = mapper;

        }

        public async Task<CreateIssueResponse> Handle(CreateIssueCommand request, CancellationToken cancellationToken)
        {

          

            var validator = new CreateIssueCommandValidation();

            var results = validator.Validate(request);

            var createIssueResponse = new CreateIssueResponse();

            if (results.IsValid == false)
            {
                createIssueResponse.Success = false;
                createIssueResponse.ValidationErrors = new List<string>();

                foreach (ValidationFailure error in results.Errors)
                {
                    createIssueResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

       


                if (createIssueResponse.Success == true)
            {
                var issue = new Issue()
                {
                    Summary = request.Summary,

                    Description = request.Description,
                    Priority = request.Priority,
                    Issue_id = new Guid()

                };
                await _issueRepository.AddAsync(issue);

                createIssueResponse =  _mapper.Map<CreateIssueResponse>(issue);

            }


            return createIssueResponse;
           

    








        }
    }
}