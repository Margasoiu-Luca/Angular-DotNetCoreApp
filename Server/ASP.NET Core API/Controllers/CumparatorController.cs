using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.CRUD;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CumparatorController : ControllerBase
    {

        private readonly IDBCrud<Cumparator, int> _repository;
        private readonly IMapper _mapper;

        public CumparatorController(IDBCrud<Cumparator, int> repository, IMapper mapper)
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
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // GET api/<CumparatorController>/5
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _repository.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST api/<CumparatorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CumparatorDTO value)
        {
            try
            {
                await _repository.Create(_mapper.Map<Cumparator>(value));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<CumparatorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CumparatorDTO value)
        {
            try
            {
                await _repository.Update(_mapper.Map<Cumparator>(value),id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<CumparatorController>/5
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
