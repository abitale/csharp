using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationEmpty.Controllers
{
    public class ValuesController : ApiController
    {
        //[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //[HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        //[HttpPost]
        public void Post([FromBody]string value)
        {
        }
        //[HttpPut]
        public void Put(int id, [FromBody]string value)
        {
                
        }
        //[HttpDelete]
        public void Delete(int id)
        {

        }

    }
}
