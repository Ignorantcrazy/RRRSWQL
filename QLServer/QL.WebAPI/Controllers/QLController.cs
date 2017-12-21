using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QL.WebAPI.Models;
using GraphQL.Types;
using GraphQL;
using QL.Core.Data;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QL.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class QLController : Controller
    {
        private IDocumentExecuter _DocumentExecuter { get; set; }
        private ISchema _Schema { get; set; }
        private readonly ILogger _Logger;
        //public QLController(/*IDocumentExecuter documentExecuter, ISchema schema, */ILogger<QLController> logger)
        //{
        //    //_DocumentExecuter = documentExecuter;
        //    //_Schema = schema;
        //    _Logger = logger;
        //}
       

        public QLController( IDocumentExecuter documentExecuter, ISchema schema,ILogger<QLController> logger)
        {
            
            _DocumentExecuter = documentExecuter;
            _Schema = schema;
            _Logger = logger;
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]QLQueryModel query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }
            var executionOptions = new ExecutionOptions {Schema = _Schema, Query = query.Query };

            try
            {
                var result = await _DocumentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);
                if (result.Errors?.Count > 0)
                {
                    _Logger.LogError("GraphQL errors: {0}", result.Errors);
                    return BadRequest();
                }
                _Logger.LogDebug("GraphQL execution result: {result}", JsonConvert.SerializeObject(result.Data));
                return Ok(result);
            }
            catch (Exception ex)
            {
                _Logger.LogError("Document exexuter exception", ex);
                return BadRequest(ex);
            }
        }
    }
}
