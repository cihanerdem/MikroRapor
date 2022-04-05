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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _dep;

        public DepartmentsController(IDepartmentService dep)
        {
            _dep = dep;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var res = await _dep.GetListAsync();
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
            var res = await _dep.GetByIdAsync(id);
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
        public async Task<IActionResult> Add([FromBody] DepartmentDto addMenu)
        {
            var res = await _dep.AddAsync(addMenu);
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
        public async Task<IActionResult> Update([FromBody] DepartmentDto updateMenu)
        {
            var res = await _dep.Updatesync(updateMenu);
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
            var res = await _dep.DeleteAsync(id);
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
