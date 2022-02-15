using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCNet6.Models;

namespace MVCNet6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
 
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Rookies()
    {
        return View();
    }

    public IActionResult SampleView()
    {
        return View();
    }

    public string BasicAction()
    {
        return "Very Basic One";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
