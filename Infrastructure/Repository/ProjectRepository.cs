
using Domain.IRepository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProjectRepository : BaseRepository<Project> , IProjectRepository
    {
        protected readonly BugTrackerContext _bugTrackerContext;

        public ProjectRepository(BugTrackerContext bugTrackerContext) : base(bugTrackerContext)
        {
            _bugTrackerContext = bugTrackerContext;
        }



    }
}
