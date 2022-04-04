using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService user;

        public UsersController(IUserService user)
        {
            this.user = user;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var res = await user.GetListAsync();
            if (res!=null)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await user.GetByIdAsync(id);
            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] UserDto addUser)
        {
            var res = await user.AddAsync(addUser);
            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] UserDto updateUser)
        {
            var res = await user.Updatesync(updateUser);
            if (res != null)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await user.DeleteAsync(id);
            if (res )
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(false);
            }
        }
    }
}
