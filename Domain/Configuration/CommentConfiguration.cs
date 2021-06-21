using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> modelBuilder)
        {
            modelBuilder

               .HasKey(c => c.Comment_id);

            modelBuilder


                .HasOne(comment => comment.Issue)
                .WithMany(issue => issue.Comments)
                .HasForeignKey(comment => comment.Post_id);

            modelBuilder

                .Property(comment => comment.Comment_id)
                .ValueGeneratedOnAdd();


        }




    }
}
