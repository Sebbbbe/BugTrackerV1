

using Application.ValidationResponse.BaseResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Command.Issues.CreateIssue
{
   public class CreateIssueResponse  :BaseResponse
    {
        

        public string Summary { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

     
    }
}
