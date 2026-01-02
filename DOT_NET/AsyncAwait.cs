using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AsyncAwait.Models;

namespace AsyncAwait.Controllers;

public class HomeController : Controller
{
    [ActionName("List")]
    public IActionResult GetList()
    {
        //creating a stopwatch
        var watch = new Stopwatch();
        watch.Start();
        var country = GetCountry();
        var state = GetState();
        watch.Stop();
        ViewBag.WatchMilli = watch.ElapsedMilliseconds; 
        return View("GetList");
        
    }

    [ActionName("ListAsync")]
    public async Task<ActionResult> GetListAsync()
    {
        //creating a stopwatch again
        var watch = new Stopwatch();
        watch.Start();
        await GetCountryAsync();
        var stateTask = await GetStateAsync();
        watch.Stop();
        ViewBag.WatchMillie = watch.ElapsedMilliseconds;
        return View("GetListAsync");
    }

    public string GetCountry()
    {
        Thread.Sleep(3000);
        return "india";
    }

    public string GetState()
    {
        Thread.Sleep(3000);
        return "new delhi";
    }

    public async Task<string> GetCountryAsync()
    {
        await Task.Delay(2000); //use when you want a logical delay without blocking the current thread
        return "germany";
    }

    public async Task<string> GetStateAsync()
    {
        await Task.Delay(2000);
        return "berlin";
    }
}

