using System.Collections.Generic;
using System.Web.Http;
using RandomQuoteSA.Models;

namespace RandomQuoteSA.Controllers
{
    public class ValuesController : ApiController
    {
        //public JsonResult Quote()
        //{
        //    var model = new { quote = "Blablablablablabla", author = "Pepe" };

        //    return new JsonResult() { Data = model, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //}

        // GET api/values
        public Quote Get()
        {
            // return new string[] { "value1", "value2" };
            var quote = new Quote() { Text = "Blablablablablabla", Author = "Pepe" };

            return quote;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id;
        }

        // POST api/values
        public Quote Post(List<string> val)
        //public Quote Post(string quote, string author)
        {
            var quoteObj = new Quote() { Text = val[0] + " 2!", Author = val[1] + " 2!" };

            //var quoteObj = new Quote() { Text = quote, Author = author };
            return quoteObj;
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
