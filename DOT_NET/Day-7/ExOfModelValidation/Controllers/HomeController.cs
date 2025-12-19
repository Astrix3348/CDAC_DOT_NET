using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExOfModelValidation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExOfModelValidation.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            return Content($"{person}");
        }
    }
}

