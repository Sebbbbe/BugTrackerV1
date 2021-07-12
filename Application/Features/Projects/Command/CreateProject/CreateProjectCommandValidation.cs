using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Projects.Command.CreateProject;
using FluentValidation;

namespace Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectCommandValidation : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidation()
        {
            RuleFor(p => p.Project_Name)
              .NotEmpty().WithMessage("{PropertyName} is empty ")
              .MaximumLength(50).WithMessage("{propertName} has more than 50 characters remember this is summary not description");
             



        }


    }
}
