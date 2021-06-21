using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder

             .HasKey(User => User.User_id);

            modelBuilder

                    .HasMany(user => user.Comments)
                    .WithOne(Comment => Comment.User)
                    .HasForeignKey(comment => comment.User_id);

            modelBuilder

                    .HasMany(User => User.Issues)
                    .WithOne(issue => issue.User)
                    .HasForeignKey(Issue => Issue.User_id);


            modelBuilder

                   .Property(u => u.User_id)
                   .ValueGeneratedOnAdd();
        }



    }
}
