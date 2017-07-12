using AutoMapper;
using eTracking.Interface.Services;
using eTracking.Model;
using eTracking.Model.Identity;
using eTracking.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StructureMap;

namespace eTracking.ApiControllers
{
    [Route("api/[controller]")]
    [AuthorizeRoles(UserRoleType.Administrator, UserRoleType.Lecturer)]
    public class MajorApiController : Controller
    {
        private readonly IMajorService majorService;
        private readonly IContainer container;
        private readonly IMapper mapper;

        public MajorApiController(IContainer container, IMapper mapper, IMajorService majorService)
        {
            this.container = container;
            this.majorService = majorService;
            this.mapper = mapper;
        }

        // GET api/staff
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(majorService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(majorService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Major major)
        {
            majorService.Create(major);
            return Created("", major);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Major major)
        {
            majorService.Update(major);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = majorService.Delete(id);
            if (result)
                return Ok();
            else
                return NotFound(id);
        }
    }
}
