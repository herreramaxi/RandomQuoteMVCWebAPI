using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandomQuoteSA.Models;

namespace RandomQuoteSA.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Post(string quote, string author)
        {
            var model = new Quote() { Text = quote, Author = author };

            return new JsonResult() { Data = model };
        }
    }
}