using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;
using NexusGear.ViewModels;

namespace NexusGear.Controllers;

public class PcBuilderController(IProductService products) : Controller
{
    public IActionResult Index() { ViewData["Title"] = "PC Builder — жүйеңді құрастыр"; return View(new PcBuilderViewModel { Components = products.All.Where(p => p.ComponentType != null).ToList() }); }
}
