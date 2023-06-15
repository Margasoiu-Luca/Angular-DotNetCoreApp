using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {

        private readonly IDBCrud<Produs, int> _repository;
        private readonly IMapper _mapper;

        public ProdusController(IDBCrud<Produs, int> repository, IMapper mapper)
        {                       
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/<ProdusController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repository.GetAll());
            }
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }

        // GET api/<ProdusController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _repository.Get(id));
            }
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }

        // POST api/<ProdusController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdusDTO value)
        {
            try
            {
                Produs x = _mapper.Map<Produs>(value);
                await _repository.Create(x);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<ProdusController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProdusDTO value)
        {
            try
            {
                await _repository.Update(_mapper.Map<Produs>(value), id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        // DELETE api/<ProdusController>/5
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
                return BadRequest(ex.ToString());
            }
        }
    }
}
