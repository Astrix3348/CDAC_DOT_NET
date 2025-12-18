using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelClass.Controllers
{
    public class StoreController : Controller
    {
        // GET: /<controller>/
        [Route("Store/Books/{id}")]
        public IActionResult Books()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            return Content($"<h1>Book Store with {id}</h1>", "text/html");
        }
    }
}

