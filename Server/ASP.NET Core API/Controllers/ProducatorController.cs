using Microsoft.AspNetCore.Mvc;
using Iss.AvanMagazinOnline.DB.CRUD;
using Iss.AvanMagazinOnline.DB.Models;
using Iss.AvanMagazinOnline.DB.Interfaces;
using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using ASP.NET_Core_API.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducatorController : ControllerBase
    {
        private readonly IDBCrud<Producator, int> _repository;
        //private readonly Mapper _mapper = new(new MapperConfiguration(cfg => cfg.CreateMap<ProducatorDTO, Producator>()));
        private readonly IMapper _mapper;

        public ProducatorController(IDBCrud<Producator, int> repository,IMapper mapper )
        {
            _repository = repository;
            _mapper = mapper;
        }
        

        // GET: api/<ProducatorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok( await _repository.GetAll());
        }

        // GET api/<ProducatorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _repository.Get(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProducatorController>
        [HttpPost]
        public IActionResult Post([FromBody] ProducatorDTO value)
        {
            try
            {
                Producator x = _mapper.Map<Producator>(value);
                _repository.Create(x);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProducatorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProducatorDTO value)
        {
            try
            {
                Producator x = _mapper.Map<Producator>(value);
                await _repository.Update(x, id);
                ResponseMessage resonsemsg = new ResponseMessage { status = "a functionat" };

                return Ok(resonsemsg);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        // DELETE api/<ProducatorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _repository.Delete(id);
                return Ok(new ResponseMessage { status = "a functionat" });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
