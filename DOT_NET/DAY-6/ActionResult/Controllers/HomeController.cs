using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExOfActionResult.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExOfActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public ContentResult Index()
        {
            return Content("<h1>Welcome to index</h1>");
        }

        [Route("about")]
        public JsonResult About()
        {
            Person person = new Person()
            {
                id = Guid.NewGuid(),
                firstName = "aakash",
                lastName = "gangwar",
                age = 22
            };

            return new JsonResult(person);
        }

        [Route("file-download")]
        public VirtualFileResult fileDownLoad()
        {
            return new VirtualFileResult("/midreview.pdf", "application/pdf");
        }

        public PhysicalFileResult fileDown2()
        {
            return new PhysicalFileResult(@"Desktop/signalist_documentation.pdf", "application/pdf");
        }
    }
}

