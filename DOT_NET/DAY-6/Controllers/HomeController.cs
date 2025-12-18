using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExOfController.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("/")] //this is the default routing
        public string Method1()
        {
            return "Hello This is me!";
        }

        [Route("/home")]
        public string Home()
        {
            return "hello from home";
        }
    }
}

