using BL.Services;
using Common.modelsVM;
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
    public class AskstojoinController : ControllerBase
    {
        IAskstojoinService service;

        public AskstojoinController(IAskstojoinService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetList());
        }

        [HttpPut("addAsk")]
        public IActionResult Put([FromBody] AskstojoinVM ask)
        {
            service.AddAsk(ask);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("deleteAsk")]
        public IActionResult Delete(int id)
        {
            service.DeleteAsk(id);
            return Ok();
        }
    }
}
