
using Identity.Models;
using Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity
{
    public class BugTrackerContext2 : IdentityDbContext<ApplicationUser>
    {
        public BugTrackerContext2(DbContextOptions<BugTrackerContext2> options) : base(options)
        {

        }

    }
}
