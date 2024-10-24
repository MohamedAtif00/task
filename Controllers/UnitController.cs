using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using task.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly ApplicationContext _dbContext;

        public UnitController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<UnitController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var units = _dbContext.units;

            return Ok(units);
        }

        // GET api/<UnitController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var unit = await _dbContext.units.Where(x => x.unitNo == id).FirstOrDefaultAsync();

            return Ok(unit);
        }

        // POST api/<UnitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UnitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UnitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
