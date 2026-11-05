using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;
using NexusGear.ViewModels;

namespace NexusGear.Controllers;

public class HomeController(IProductService products) : Controller
{
    public IActionResult Index() { ViewData["Title"] = "NEXUS GEAR — Болашақ технологиясы осында"; ViewBag.TotalProducts = products.All.Count; return View(new HomeViewModel { Featured = products.All.Where(p => p.IsFeatured).Take(6).ToList(), ProductCount = products.All.Count }); }
    public IActionResult Error() => View();
}
