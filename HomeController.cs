using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SRS SRS1 = new SRS(28/03/2023, "2.8.9", "Back_End_project", "duda costa");

        List<SRS> listaSRS = new List<SRS>();
        listaSRS.Add(SRS1);
        
        ViewBag.listaSRS = listaSRS;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
