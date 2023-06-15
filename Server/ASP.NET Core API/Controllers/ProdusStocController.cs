using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusStocController : ControllerBase
    {
        private readonly IDBCrud<ProdusStoc, int> _repository;
        private readonly IMapper _mapper;

        public ProdusStocController(IDBCrud<ProdusStoc, int> repository, IMapper mapper)
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
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }

        // GET api/<StocProdusController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                 return Ok(await _repository.Get(id));
            }
            catch(Exception ex) { return BadRequest(ex.ToString()); }
        }

        // POST api/<StocProdusController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdusStocDTO value)
        {
            try
            {
                await _repository.Create(_mapper.Map<ProdusStoc>(value));
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }

        // PUT api/<StocProdusController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProdusStocDTO value)
        {
            try
            {
                await _repository.Update(_mapper.Map<ProdusStoc>(value),id);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }

        // DELETE api/<StocProdusController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.ToString()); }
        }
    }
}
