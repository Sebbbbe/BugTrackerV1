
using Domain.IRepository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IssueRepository : BaseRepository<Issue> , IIssueRepository
    {
        protected readonly BugTrackerContext _bugTrackerContext;

        public IssueRepository(BugTrackerContext bugTrackerContext) : base(bugTrackerContext)
        {
            _bugTrackerContext = bugTrackerContext;
        }



    }
}
