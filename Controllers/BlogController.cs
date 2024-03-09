using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPRazor.Models;

namespace ASPRazor.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    public IActionResult Article()
    {
        return View();
    }

    public IActionResult Privacy(string id)
    {
        Console.WriteLine(Request.Query["tab"]);
        ViewBag.ArticleId = id;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
