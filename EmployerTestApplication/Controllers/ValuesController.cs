using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace EmployerTestApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            
            return Ok(new string[] { "value1", "value2" });
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            throw new Exception();
            if(id == 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
