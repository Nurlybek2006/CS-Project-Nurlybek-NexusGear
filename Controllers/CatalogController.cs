using Microsoft.AspNetCore.Mvc;
using NexusGear.Services;
using NexusGear.ViewModels;

namespace NexusGear.Controllers;

public class CatalogController(IProductService products) : Controller
{
    public IActionResult Index(string? q, string? category, string sort = "featured")
    {
        var result = products.Search(q, category).AsEnumerable();
        result = sort switch { "price-asc" => result.OrderBy(p => p.Price), "price-desc" => result.OrderByDescending(p => p.Price), "name" => result.OrderBy(p => p.Name), _ => result.OrderByDescending(p => p.IsFeatured).ThenBy(p => p.Name) };
        ViewData["Title"] = "Технологиялар каталогы"; ViewBag.TotalProducts = result.Count();
        return View(new CatalogViewModel { Products = result.ToList(), Categories = products.All.Select(p => p.Category).Distinct().ToList(), Query = q, Category = category, Sort = sort });
    }
}
