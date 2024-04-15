using Autofac.Core;
using Business.Abstract;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TService> : ControllerBase
        where T : class, IEntity, new()
        where TService : IBaseService<T>
    {
        private readonly TService _baseService;

        public BaseController(TService baseService)
        {
            _baseService = baseService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _baseService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var result = _baseService.GetById(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] T t)
        {
            var result = _baseService.Add(t);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] T t)
        {
            var result = _baseService.Delete(t);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] T t)
        {
            var result = _baseService.Update(t);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

