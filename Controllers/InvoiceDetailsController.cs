﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailsController : ControllerBase
    {
        private readonly DbContext  _dbContext;

        public InvoiceDetailsController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<InvoiceDetailsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
            
        //}

        // GET api/<InvoiceDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InvoiceDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InvoiceDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InvoiceDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
