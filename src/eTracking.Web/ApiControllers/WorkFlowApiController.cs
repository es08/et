using AutoMapper;
using eTracking.Interface.Services;
using eTracking.Model;
using eTracking.Model.Identity;
using eTracking.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using StructureMap;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTracking.Web.ApiControllers
{
    [Route("api/[controller]")]
    [AuthorizeRoles(UserRoleType.Administrator, UserRoleType.Lecturer)]
    public class WorkFlowApiController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IContainer container;
        private readonly IMapper mapper;

        public WorkFlowApiController(IContainer container, IMapper mapper, IProjectService projectService)
        {
            this.container = container;
            this.projectService = projectService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(mapper.Map<IList<WorkFlowViewModel>>(projectService.GetWorkFlows()));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(projectService.GetWorkFlowById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]WorkFlowViewModel workflow)
        {
            if (workflow != null)
            {               
                var newWorkflow = mapper.Map<WorkFlow>(workflow);
                projectService.CreateWorkFlow(newWorkflow);
                return Created("", newWorkflow);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]WorkFlowViewModel workflow)
        {
            if (workflow != null)
            {               
                projectService.UpdateWorkFlow(mapper.Map<WorkFlowViewModel, WorkFlow>(workflow, projectService.GetWorkFlowById(id)));
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = projectService.DeleteWorkFlow(id);
            if (result)
                return Ok();
            else
                return NotFound(id);
        }
    }
}
