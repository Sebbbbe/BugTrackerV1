using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Issues.Query
{
    public  interface IGetAllIssuesService
    {
         Task<List<GetAllIssuesResponse>> Get();
    }
}
