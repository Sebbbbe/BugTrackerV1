using Application.Features.Projects.Command.CreateProject;
using Application.Services;
using AutoMapper;
using Domain.IRepository;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.Tests.Projects.Commands
{
   public class CreateProjectTests
    {
        private readonly IMapper _mapper;

        private readonly Mock<IProjectRepository> _mockProjectRepository;

        public CreateProjectTests()
        {

             _mockProjectRepository = ProjectRepositoryMocks.GetProjectRepository();



            var mappingConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });


          
            _mapper = mappingConfiguration.CreateMapper();

        }


      


        [Fact]


        public async Task Handle_ValidProject_AddedToProjectRepo()
        {



            var projects =await _mockProjectRepository.Object.ListAllAsync();

            projects.Count.ShouldBe(1);

           


           

        }


    }
}
