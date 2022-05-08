using BL.Services;
using Common.modelsVM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JoiningsController : ControllerBase
    {
        IJoiningsService service;

        public JoiningsController(IJoiningsService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetList());
        }

        [HttpPut("addJoining")]
        public void Put([FromBody] JoiningsVM j)
        {
            service.AddJoining(j);
        }
    }
}
