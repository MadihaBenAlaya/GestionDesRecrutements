using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppRecrutement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatureController : ControllerBase
    {
        // GET: api/<CandidatureController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CandidatureController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CandidatureController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandidatureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidatureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
