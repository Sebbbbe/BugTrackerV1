using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using FluentValidation;

namespace Application.Validators
{
    public class IssueValdiator : AbstractValidator<Issue>
    {
        public IssueValdiator()
        {
            RuleFor(p => p.Summary)
                .NotEmpty().WithMessage("{PropertyName} is empty ")
                .MaximumLength(50).WithMessage("{propertName} has more than 50 characters remember this is summary not description");



            RuleFor(p => p.Priority)
                .MaximumLength(6).WithMessage("{PropertName} is not valid please choose low , medium  or high");

            RuleFor(p => p.Description)
                .MaximumLength(1000).WithMessage("{PropertName} is not valid since it's over 1000 characters");
                
        }

       




    }
}
