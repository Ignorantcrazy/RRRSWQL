using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QL.WebAPI.Models;
using GraphQL.Types;
using GraphQL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QL.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class QLController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]QLQueryModel query)
        {
            var schema = new Schema {Query = new QLQuery() };
            var result = await new DocumentExecuter().ExecuteAsync(_ => { 
                _.Schema = schema;
                _.Query = query.Query;
            }).ConfigureAwait(false);
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
