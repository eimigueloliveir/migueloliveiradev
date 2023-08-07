﻿using Microsoft.AspNetCore.Mvc;
using migueloliveiradev.Database;
using migueloliveiradev.Repositories.Home;
using migueloliveiradev.ViewsModel;

namespace migueloliveiradev.Controllers;

public class HomeController : Controller
{
    private readonly IHomeRepository repository;
    public HomeController(IHomeRepository repository)
    {
        this.repository = repository;
    }
    [Route("/")]
    public IActionResult Home()
    {
        HomeViewModel model = repository.GetHomeViewModel();
        return View(model);
    }
}