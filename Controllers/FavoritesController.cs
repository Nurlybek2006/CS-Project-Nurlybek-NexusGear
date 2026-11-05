using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;

namespace NexusGear.Controllers;

public class FavoritesController(IProductService products) : Controller
{
    public IActionResult Index([FromQuery] int[]? ids) { ViewData["Title"] = "Таңдаулылар"; return View((ids ?? []).Distinct().Select(products.Find).Where(p => p is not null).ToList()!); }
}
