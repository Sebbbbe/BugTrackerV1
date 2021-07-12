using Domain.IRepository;
using Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xunit.Tests.Mocks
{
    public class IssuesRepositoryMocks
    {
        public static Mock<IIssueRepository> GetIssueRepository()
        {
            //var bugIssueGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            //var taskGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");

            var issues = new List<Issue>
            {
                new Issue
                {
                    //Issue_id = bugIssueGuid,
                    Issue_id = new Guid(),
                    Summary = "Problem with layout",
                    Priority = "medium",
                    Description = "Button wont center please help ! XD"
                }
               

            };
       

         // gör en mock variabel
            var mockIssueRepository = new Mock<IIssueRepository>();

            // gör en mock (kopia) av issue som  ListAllAsync behöver säga returnsAsync för att returnera
            mockIssueRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(issues);


            //verkas inte behöva denna nedre

            //mockIssueRepository.Setup(repo => repo.AddAsync(It.IsAny<Issue>())).ReturnsAsync(
            //    (Issue issue) =>
            //    {
            //        issues.Add(issue);
            //        return issue;
            //    });

            return mockIssueRepository;
        }
    }
}