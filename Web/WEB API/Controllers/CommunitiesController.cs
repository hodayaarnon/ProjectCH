using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        ICommunitiesService service;

        public CommunitiesController(ICommunitiesService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAllCommunities());
        }
        [HttpGet]
        [Route("GetUserCommunities/{id}")]
        public IActionResult GetUserCommunities(int id)
        {
            return Ok(service.GetUserCommunities(id));
        }
        [HttpGet]
        [Route("GetCommunityById/{id}")]
        public IActionResult GetCommunityById(int id)
        {
            return Ok(service.GetCommunityById(id));
        }

    }
}
