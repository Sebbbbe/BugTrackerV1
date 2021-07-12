using Application.Features.Issues.Query;
using Application.Features.Projects.Command.CreateProject;
using Domain.IRepository;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProjectRepository _ProjectRepository;

        public ProjectController(IMediator mediator, IProjectRepository ProjectRepository)
        {
            _mediator = mediator;
            _ProjectRepository = ProjectRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateProjectCommand createProjectCommand)
        {

            var response = await _mediator.Send(createProjectCommand);
            return Ok(response);
        }

    }
    }
