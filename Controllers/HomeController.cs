using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestCRM.Models;

namespace TestCRM.Controllers;

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

    [HttpGet]
    public IActionResult Form()
    {
        return View(new UserModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SendName(UserModel user = null)
    {
        UserModel userProfile = new(user.Id, user.Name, user.SurName);

        if (ModelState.IsValid)
        {
            return View(userProfile);
        }
        
        return RedirectToAction("Form");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
