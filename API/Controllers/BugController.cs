using API.Contracts.Requests.Bugs;
using API.Contracts.Views.Bugs;
using API.Models;
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


        // POST <BugController>
        [HttpPost]
        public void Post([FromBody] BugCreateRequest input) =>
            ToWithStatus(_service.Create(input));


        // GET: <BugController>
        [HttpGet("bugs")]
        public void Get(string project_id, string user_id
                                        , string start_date, string end_date) =>
            ToWithStatus(_service.GetListByAllParameters(project_id, user_id,
                                                      start_date,end_date));

        //// GET api/<BugController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/<BugController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BugController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
