using NexusGear.Models;

namespace NexusGear.Services;

public interface IProductService
{
    IReadOnlyList<Product> All { get; }
    Product? Find(int id);
    IReadOnlyList<Product> Search(string? query, string? category = null);
}
