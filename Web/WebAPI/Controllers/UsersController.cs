using BL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetList());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetById(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("GetUserByEmail")]
        public IActionResult GetUserByEmail(string Email)
        {
            return Ok(service.GetUserByEmail(Email));
        }
        [HttpGet]
        [Route("GetUserByEmailAndPassword")]
        public IActionResult GetUserByEmailAndPassword(string Email, string password)
        {
            return Ok(service.GetUserByEmail(Email));
        }

       
    }
}
