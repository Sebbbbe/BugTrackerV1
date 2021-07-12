using Application.ValidationResponse.BaseResponse;

namespace Application.Features.Issues.Command.CreateIssue
{
    public class CreateIssueResponse : BaseResponse
    {


        public string Summary { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }


    }
}
