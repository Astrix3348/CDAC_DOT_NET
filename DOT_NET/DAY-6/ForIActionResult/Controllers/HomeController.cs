using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForIActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore")]
        public IActionResult Index()
        {
            //book id should be provided
            if (!Request.Query.ContainsKey("bookid"))
            {
                Response.StatusCode = 400; //in place of this
                //we can also write this
                return BadRequest("Book id is not provided");


            }

            //book id cannot be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                return BadRequest("Book id cannot be null or empty");
            }

            int bookid = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);
            if(bookid <= 0)
            {
                Response.StatusCode = 400;
                return Content("book id cannot be less than 0");
            }
            if(bookid > 1000)
            {
                Response.StatusCode = 400;
                return Content("book id cannot be greater than  999");
            }
            if (Convert.ToBoolean(Request.Query["isLoggedin"]) == false)
            {
                return Unauthorized("user must be authenticated");
            }

            return new RedirectToActionResult("Books", "Store", new { }, true);
        }
    }
}

