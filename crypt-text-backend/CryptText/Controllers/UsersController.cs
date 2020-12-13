using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptText.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptText.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService usersService;

        // GET api/values/5
        [HttpPut("connect")]
        public void Get([FromBody] string userUuid)
        {
            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
