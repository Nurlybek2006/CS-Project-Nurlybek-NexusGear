using NexusGear.Models;

namespace NexusGear.ViewModels;

public sealed class HomeViewModel { public IReadOnlyList<Product> Featured { get; init; } = []; public int ProductCount { get; init; } }
public sealed class CatalogViewModel { public IReadOnlyList<Product> Products { get; init; } = []; public IReadOnlyList<string> Categories { get; init; } = []; public string? Query { get; init; } public string? Category { get; init; } public string Sort { get; init; } = "featured"; }
public sealed class ProductDetailsViewModel { public Product Product { get; init; } = new(); public IReadOnlyList<Product> Related { get; init; } = []; }
public sealed class PcBuilderViewModel { public IReadOnlyList<Product> Components { get; init; } = []; }
public sealed class CompareViewModel { public IReadOnlyList<Product> Products { get; init; } = []; }
