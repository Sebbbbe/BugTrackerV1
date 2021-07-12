using Domain.IRepository;
using Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Mocks
{
    public class ProjectRepositoryMocks
    {

        public  static Mock<IProjectRepository> GetProjectRepository()
        {

            var project = new List<Project>
            {
            new Project

            {
                Project_id = new Guid(),
                Project_Name = "Testing"
            }
                   };



            //Arrange

            var mockProjectRepository = new Mock<IProjectRepository>();



            //assert
             mockProjectRepository.Setup(set => set.ListAllAsync()).ReturnsAsync(project);

            //act

            return mockProjectRepository;

        }
    }

}
