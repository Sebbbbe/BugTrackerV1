
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
using System.Runtime.Intrinsics.X86;


namespace Application.Features.Issues.Command.CreateIssue
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


            var createIssueResponse = new CreateIssueResponse();

            var validator = new CreateIssueValidation();

            var results = validator.Validate(request);



            if (results.IsValid == false)
            {
                createIssueResponse.Success = false;
                createIssueResponse.ValidationErrors = new List<string>();

                foreach (var error in results.Errors)
                {
                    createIssueResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }




            if (results.IsValid == true)
            {
                var issue = new Issue()
                {
                    Summary = request.Summary,

                    Description = request.Description,
                    Priority = request.Priority,
                    Issue_id = new Guid()

                };
                await _issueRepository.AddAsync(issue);
                createIssueResponse = _mapper.Map<CreateIssueResponse>(issue);
            }



            return createIssueResponse;











        }
    }
}