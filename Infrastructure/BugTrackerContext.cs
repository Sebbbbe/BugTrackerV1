using Domain.Models;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.AuthenticationModels;

namespace Infrastructure
{
   public class BugTrackerContext : IdentityDbContext<ApplicationUser>
    {
        
        
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) 
            : base(options)
        {
           

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BugTrackerContext).Assembly);
        }

     

        public DbSet<Comment> Comments { get; set; }  
        public DbSet<Issue> Issues { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }

    }

   
}
