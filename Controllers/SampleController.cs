using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using coreApi.Interfaces;
using coreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
namespace coreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly IRepository _repository;
        public SampleController(AppDBContext context, IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<member>>> GetMember()
        {
            var model =  await _repository.SelectAll<member>();
            return model;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<member>> GetMember(long id)
        {
            var model = await _repository.SelectById<member>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMember(long id, member  model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<member>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<member>> InsertMember(member model)
        {
            await _repository.CreateAsync<member>(model);
            return CreatedAtAction("GetMember", new { id = model.Id }, model); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<member>> DeleteMember(long id)
        {
            var model = await _repository.SelectById<member>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<member>(model);

            return model;
        }
    }
}