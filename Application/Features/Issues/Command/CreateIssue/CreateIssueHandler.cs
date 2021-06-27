
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using AutoMapper;
using MediatR;
using System.Threading;

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
            
            var issue = new Issue
            {
                Summary = request.Summary,
                Category = request.Category,
                Description = request.Description,
                Priority = request.Priority,
                Issue_id = new Guid()

            }; 

            await _issueRepository.AddAsync(issue);

            return _mapper.Map<CreateIssueResponse>(issue);








        }
    }
}