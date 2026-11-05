using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;
using NexusGear.ViewModels;

namespace NexusGear.Controllers;

public class ProductController(IProductService products) : Controller
{
    public IActionResult Details(int id) { var product = products.Find(id); if (product is null) return NotFound(); ViewData["Title"] = product.Name; return View(new ProductDetailsViewModel { Product = product, Related = products.Search(null, product.Category).Where(p => p.Id != id).Take(4).ToList() }); }
    public IActionResult QuickView(int id) { var product = products.Find(id); return product is null ? NotFound() : PartialView("_ProductQuickView", product); }
    [HttpGet("api/products")] public IActionResult Data([FromQuery] int[]? ids) { var list = ids is { Length: > 0 } ? products.All.Where(p => ids.Contains(p.Id)) : products.All; return Json(list.Select(p => new { p.Id, p.Name, p.Brand, p.Category, p.Price, p.IsAvailable, p.ImageUrl, p.Specifications, p.ComponentType, p.Wattage, p.Specs })); }
}
