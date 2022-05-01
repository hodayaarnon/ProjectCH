using BL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        IRolesService service;
        public RolesController(IRolesService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetUserRolesInCommunity")]
        public IActionResult GetUserRolesInCommunity(int userid, int comid)
        {
            return Ok(service.GetUserRolesInCommunity(userid, comid));
        }
        [HttpGet]
        [Route("isCommunityManager")]
        public IActionResult isCommunityManager(int userid, int comid)
        {
            return Ok(service.isCommunityManager(userid, comid));
        }
        //[HttpGet]
        //[Route("isAuthorizedToPublish")]
        //public IActionResult isAuthorizedToPublish(int userid, int comid)
        //{
        //    return Ok(service.isAuthorizedToPublish(userid, comid));
        //}

    }
}
