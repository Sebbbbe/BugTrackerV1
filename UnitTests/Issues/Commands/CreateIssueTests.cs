
using Application.Services;
using AutoMapper;
using Domain.IRepository;
using Domain.Models;
using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit.Tests.Mocks;
using Xunit;
using Shouldly;
using Application.Features.Issues.Command.CreateIssue;
using Application.Features.Projects.Command.CreateProject;

namespace Xunit.Tests.Issues.Commands
{
    public class CreateIssueTests
    {

        private readonly IMapper _mapper;
        private readonly Mock<IIssueRepository> _mockIssueRepository;

        public CreateIssueTests()
        {
            _mockIssueRepository = RepositoryMocks.GetIssueRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }


        //testar de 2 olika i repositorymocks och 1 här som sammanlagt blir 3 och det blir 3
      
        [Fact]
        public async Task Handle_ValidIssue_AddedToIssueRepo()
        {
            var handler = new CreateIssueHandler(_mockIssueRepository.Object, _mapper);

            await handler.Handle(new CreateIssueCommand() { Summary = "Test" }, CancellationToken.None);

            var allIssues = await _mockIssueRepository.Object.ListAllAsync();
            allIssues.Count.ShouldBe(3);
        }
    }
}

