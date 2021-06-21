using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder

              .HasKey(project => project.Project_id);

            modelBuilder

                   .HasMany(project => project.Issues)
                   .WithOne(Issue => Issue.Project)
                   .HasForeignKey(issue => issue.Project_id);

            modelBuilder

                    .Property(p => p.Project_id)
                    .ValueGeneratedOnAdd();

            modelBuilder

                    .Property(project => project.Project_Name)
                    .IsRequired();
        }



    }
}
