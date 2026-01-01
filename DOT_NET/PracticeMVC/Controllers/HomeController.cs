using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Models;

namespace PracticeMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult showDetails(Student student)
    {
        return View(student);

    }

}

