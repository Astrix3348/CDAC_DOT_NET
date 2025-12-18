using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore/{bookid?}/{isLoggedin?}")] //routeData -- this is the highest priority
        public IActionResult Index(int? bookid, bool? isLoggedin)
        {
            if(bookid.HasValue == false)
            {
                return BadRequest("book id is not given");
            }
            if(bookid <= 0)
            {
                return BadRequest("book id cannot be less than 0");
            }

            return new RedirectToActionResult("Books", "Store", new {}, true);
        }
    }
}

