using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeltaXApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeltaXApi.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET api/values
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
        public void Post([FromBody]MovieItemResource movieItem)
        {
            if (movieItem == null)
            {
                throw new ArgumentNullException(nameof(movieItem));
            }
            

            
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
