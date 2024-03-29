using API.Contracts.Requests.Bugs;
using API.Contracts.Views.Bugs;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

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
        public ObjectResult Post([FromBody] BugCreateRequest input) =>
            ToWithStatus(_service.Create(input));


        // GET: <BugController>
        [HttpGet("bugs")]
        public ObjectResult Get(string? project_id, string? user_id
                                        , string? start_date, string? end_date)
        {
            var response = new BugListResponseView();
            try
            {
                if (project_id == null && user_id == null && start_date == null && end_date == null)
                {
                    return ToWithStatus(response.ToFail<BugListResponseView>("", HttpStatusCode.NotFound));
                }
                DateTime? startOfInterval = start_date == null ? null :
                            DateTime.ParseExact(start_date, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                DateTime? endOfInterval = end_date == null ? null :
                            DateTime.ParseExact(end_date, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                Regex regexIsGuid = new Regex("^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$");
                if (project_id != null && !regexIsGuid.IsMatch(project_id))
                {
                    throw new Exception("identificación de proyecto incorrecta");
                }
                if (user_id != null && !regexIsGuid.IsMatch(user_id))
                {
                    throw new Exception("identificación de usuario incorrecta");
                }
                return ToWithStatus(_service.GetListByParameters(project_id, user_id,
                                                          startOfInterval, endOfInterval));
            }
            catch (Exception ex)
            {
                return ToWithStatus(response.ToFail<BugListResponseView>(ex, HttpStatusCode.NotFound));
            }
        }
            

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
