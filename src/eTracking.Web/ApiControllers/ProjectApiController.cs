using AutoMapper;
using eTracking.Interface.Services;
using eTracking.Model;
using eTracking.Model.Identity;
using eTracking.Web;
using eTracking.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StructureMap;
using System.Collections.Generic;

namespace eTracking.ApiControllers
{
    [Route("api/[controller]")]
    [AuthorizeRoles(UserRoleType.Administrator, UserRoleType.Lecturer)]
    public class ProjectApiController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IProjectStatusService projectStatusService;
        private readonly IContainer container;
        private readonly IMapper mapper;

        public ProjectApiController(IContainer container, IMapper mapper, IProjectService projectService,
            IProjectStatusService projectStatusService)
        {
            this.container = container;
            this.projectService = projectService;
            this.projectStatusService = projectStatusService;
            this.mapper = mapper;
        }

        [HttpGet("[action]")] // Matches '/Project/ProjectStatus'
        public IActionResult ProjectStatus()
        {
            return Ok(projectStatusService.GetAll());
        }

        [HttpGet("[action]/{id}")] // Matches '/Project/ProjectStatus/{id}'
        public IActionResult ProjectStatus(int id)
        {
            return Ok(projectStatusService.GetById(id));
        }

        // GET api/staff
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(mapper.Map<IList<ProjectViewModel>>(projectService.GetAll()));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(mapper.Map<ProjectViewModel>(projectService.GetById(id)));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Project project)
        {
            projectService.Create(project);
            return Created("", project);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Project project)
        {
            projectService.Update(project);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = projectService.Delete(id);
            if (result)
                return Ok();
            else
                return NotFound(id);
        }
    }
}
