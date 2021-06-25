using Application.Features.Command.Issues.CreateIssue;
using AutoMapper;
using Domain.IRepository;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Issues.Query
{
    public class GetAllIssuesHandler : IGetAllIssuesService 
    {
   
            private readonly IIssueRepository _issueRepository;
            private readonly IMapper _mapper;


            public GetAllIssuesHandler(IIssueRepository issueRepository, IMapper mapper)
            {
                _issueRepository = issueRepository;
                _mapper = mapper;

            }

          
            public async Task<List<GetAllIssuesResponse>> Get()
            {

           var listAllIssues = await  _issueRepository.ListAllAsync();

               return _mapper.Map<List<GetAllIssuesResponse>>(listAllIssues);



            }
           

              








          
        }
    }
