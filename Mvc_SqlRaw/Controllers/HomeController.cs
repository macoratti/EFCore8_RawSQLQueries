using Microsoft.AspNetCore.Mvc;
using Mvc_SqlRaw.Models;
using System.Diagnostics;

namespace Mvc_SqlRaw.Controllers;
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
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
