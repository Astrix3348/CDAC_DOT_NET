using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelClass.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelClass.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore/{boookid?}/{isLoggedin?}")]
        public IActionResult Index([FromRoute] int? bookid, [FromRoute] bool? isLoggedin, Book book) {
            if(bookid == 3)
            {
                return BadRequest("book id was not given");
            }

            if(isLoggedin == false)
            {
                return Unauthorized("not authenticated");
            }

            return Content($"Book id: {bookid}, Book: {book}", "text/plain");
        } 
    }
}

