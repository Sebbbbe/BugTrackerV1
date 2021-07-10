using Domain.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Infrastructure
{
   public class BugTrackerContext : DbContext 
    {
        
        
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) 
            : base(options)
        {
           

        }

        public BugTrackerContext()
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
