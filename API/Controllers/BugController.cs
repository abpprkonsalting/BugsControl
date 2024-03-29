using API.Contracts.Requests.Bugs;
using API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BugController : BaseController
    {
        private readonly IBugService _service;

        public BugController(IBugService service) => _service = service;

        // GET: api/<BugController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BugController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BugController>
        [HttpPost]
        public void Post([FromBody] BugCreateRequest input) =>
            ToWithStatus(_service.Create(input));

        // PUT api/<BugController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BugController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
