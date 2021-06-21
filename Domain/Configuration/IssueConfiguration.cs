using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {

        public void Configure(EntityTypeBuilder<Issue> modelBuilder)
        {
            modelBuilder

                  .HasKey(issue => issue.Issue_id);

            modelBuilder

                    .HasOne(issue => issue.User)
                    .WithMany(user => user.Issues)
                    .HasForeignKey(issue => issue.User_id);



            modelBuilder

                    .Property(i => i.Issue_id)
                    .ValueGeneratedOnAdd();

            modelBuilder

                  .HasOne(i => i.Project)
                  .WithMany(p => p.Issues)
                  .HasForeignKey(i => i.Project_id);

        }


    }
}
