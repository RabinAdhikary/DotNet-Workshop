using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnet.Models;

namespace Dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {

        _logger = logger;
    }

    public IActionResult Index()

    {
        var list =new List<StudentVm>(){
            new StudentVm(){Id=1, Name="rajan baklol",Address="Pagal khana"},
            new StudentVm(){Id=2, Name="Rajan khatam",Address="Mental Hospital"},
        };
        return View(list);
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
    public IActionResult Test(){
        return View();
    }
}
