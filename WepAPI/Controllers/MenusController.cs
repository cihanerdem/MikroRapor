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
    public class MenusController : ControllerBase
    {
        private readonly IAppMenuService _app;

        public MenusController(IAppMenuService app)
        {
            _app = app;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var res = await _app.GetListAsync();
            if (res != null)
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
            var res = await _app.GetByIdAsync(id);
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
        public async Task<IActionResult> Add([FromBody] AppMenuDto addMenu)
        {
            var res = await _app.AddAsync(addMenu);
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
        public async Task<IActionResult> Update([FromBody] AppMenuDto updateMenu)
        {
            var res = await _app.Updatesync(updateMenu);
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
            var res = await _app.DeleteAsync(id);
            if (res)
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
