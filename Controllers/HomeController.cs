using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestCRM.Data;
using TestCRM.Models;
using System;
using System.Collections.Generic;

namespace TestCRM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TestCRMContext _context;

    public HomeController(ILogger<HomeController> logger, TestCRMContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.UserModel.ToList());
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
        UserModel userProfile = new(user.Name, user.SurName);

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
