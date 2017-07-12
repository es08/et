using AutoMapper;
using eTracking.Identity;
using eTracking.Interface.Services;
using eTracking.Model;
using eTracking.Model.Identity;
using eTracking.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StructureMap;

namespace eTracking.ApiControllers
{
    [Route("api/[controller]")]
	[Authorize(Roles = UserRoleType.Administrator)]
    // [Authorize(Policy = "CanViewAllUsers")]
    public class StaffApiController : Controller
    {
        //return NoContent();
        //return BadRequest();
        //return Unauthorized();
        //return NotFound();
        private readonly IStaffService staffService;
        private readonly IPositionService positionService;
        private readonly IContainer container;
        private readonly IMapper mapper;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger logger;


        public StaffApiController(IContainer container, IMapper mapper, IStaffService staffService,
            IPositionService positionService, UserManager<ApplicationUser> userManager, ILogger<StaffApiController> logger,
        SignInManager<ApplicationUser> signInManager )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.container = container;
            this.staffService = staffService;
            this.positionService = positionService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet("[action]")]
        public IActionResult Position()
        {
            return Ok(positionService.GetAll());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult Position(int id)
        {
            return Ok(positionService.GetById(id));
        }

        // GET api/staff
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(staffService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(staffService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]StaffViewModel staff)
        {
            //Example: How to use Automapper and how to create new object with Structure map
            //staffService.Create(mapper.Map<StaffViewModel, Staff>(staff, container.GetInstance<Staff>()));
            return Created("", staff);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]StaffViewModel staff)
        {
            staffService.Update(mapper.Map<Staff>(staff));
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = staffService.Delete(id);
            if (result)
                return Ok();
            else
                return NotFound(id);
        }
    }
}
