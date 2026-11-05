using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;
using NexusGear.ViewModels;

namespace NexusGear.Controllers;

public class CompareController(IProductService products) : Controller
{
    public IActionResult Index([FromQuery] int[]? ids) { var selected = (ids ?? []).Distinct().Take(3).Select(products.Find).OfType<NexusGear.Models.Product>().ToList(); ViewData["Title"] = "Өнімдерді салыстыру"; return View(new CompareViewModel { Products = selected }); }
}
