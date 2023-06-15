using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieProdusController : ControllerBase
    {

        private readonly IDBCrud<CategorieProdus, int> _repository;
        private readonly IMapper _mapper;

        // GET: api/<CategorieProdusController>
        public CategorieProdusController(IDBCrud<CategorieProdus, int> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<CategorieProdusController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _repository.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CategorieProdusController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategorieProdusDTO value)
        {
            try
            {
                CategorieProdus x = _mapper.Map<CategorieProdus>(value);
                await _repository.Create(x);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CategorieProdusController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            try
            {
                CategorieProdus x = _mapper.Map<CategorieProdus>(value);
                await _repository.Update(x, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CategorieProdusController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
