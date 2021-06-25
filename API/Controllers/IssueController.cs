using Application.Features.Command.Issues.CreateIssue;
using Application.Features.Issues.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class IssueController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGetAllIssuesService _getAllIssuesService;

        public IssueController(IMediator mediator, IGetAllIssuesService getAllIssuesService)
        {
            _mediator = mediator;
            _getAllIssuesService = getAllIssuesService;
        }
        //// GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

     //// GET api/<ValuesController>/5
     //[HttpGet("{id}")]
     //public string Get(int id)
     //{
     //    return "value";
     //}

     // POST api/<ValuesController>
     [HttpPost]
        public async Task Post(CreateIssueCommand CreateIssueCommand)
        {

           await _mediator.Send(CreateIssueCommand);
          
        }


        [HttpGet]
        public async Task<List<GetAllIssuesResponse>> GetAllIssues()
        {
            return await _getAllIssuesService.Get();
        }


        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
