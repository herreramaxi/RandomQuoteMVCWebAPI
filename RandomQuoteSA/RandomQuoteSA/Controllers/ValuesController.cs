using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using RandomQuoteSA.Models;

namespace RandomQuoteSA.Controllers
{
    public class ValuesController : ApiController
    {
        public JsonResult Quote()
        {
            var model = new { quote = "Blablablablablabla", author = "Pepe" };

            return new JsonResult() { Data = model, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // GET api/values
        public Quote Get()
        {
            // return new string[] { "value1", "value2" };
            var quote = new Quote() {Text= "Blablablablablabla", Author = "Pepe" };

            return quote;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id;
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
