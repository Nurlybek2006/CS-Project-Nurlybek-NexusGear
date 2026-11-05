using NexusGear.Models;

namespace NexusGear.Services;

public sealed class ProductService : IProductService
{
    private readonly List<Product> _products = Seed();
    public IReadOnlyList<Product> All => _products;
    public Product? Find(int id) => _products.FirstOrDefault(p => p.Id == id);
    public IReadOnlyList<Product> Search(string? query, string? category = null)
    {
        IEnumerable<Product> items = _products;
        if (!string.IsNullOrWhiteSpace(query)) items = items.Where(p => $"{p.Name} {p.Brand} {p.Category}".Contains(query.Trim(), StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(category)) items = items.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        return items.ToList();
    }

    private static List<Product> Seed()
    {
        var rows = new (string Brand, string Name, string Category, int Price, string Type, int Watts, string Specs)[]
        {
            ("NVIDIA","GeForce RTX 5090 32GB","Видеокарталар",1899000,"GPU",575,"32 GB GDDR7 · 304 мм"),("NVIDIA","GeForce RTX 5080 16GB","Видеокарталар",999000,"GPU",360,"16 GB GDDR7 · 304 мм"),("NVIDIA","GeForce RTX 5070 Ti","Видеокарталар",699000,"GPU",300,"16 GB GDDR7 · 285 мм"),("NVIDIA","GeForce RTX 5070","Видеокарталар",529000,"GPU",250,"12 GB GDDR7 · 260 мм"),("AMD","Radeon RX 9070 XT","Видеокарталар",579000,"GPU",304,"16 GB GDDR6 · 300 мм"),("AMD","Radeon RX 9060 XT","Видеокарталар",349000,"GPU",190,"16 GB GDDR6 · 280 мм"),
            ("AMD","Ryzen 9 9950X","Процессорлар",359000,"CPU",170,"AM5 · 16 ядро"),("AMD","Ryzen 7 9800X3D","Процессорлар",289000,"CPU",120,"AM5 · 8 ядро"),("AMD","Ryzen 7 9700X","Процессорлар",219000,"CPU",65,"AM5 · 8 ядро"),("AMD","Ryzen 5 9600X","Процессорлар",159000,"CPU",65,"AM5 · 6 ядро"),("Intel","Core Ultra 9 285K","Процессорлар",339000,"CPU",250,"LGA1851 · 24 ядро"),("Intel","Core Ultra 7 265K","Процессорлар",239000,"CPU",250,"LGA1851 · 20 ядро"),
            ("ASUS","ROG Zephyrus G16","Ноутбуктер",1299000,"",0,"RTX 5070 · OLED 240 Hz"),("Lenovo","Legion Pro 7i","Ноутбуктер",1199000,"",0,"RTX 5080 · 16 inch"),("ASUS","TUF Gaming A15","Ноутбуктер",629000,"",0,"RTX 4060 · 144 Hz"),("Apple","MacBook Pro 14","Ноутбуктер",1099000,"",0,"M4 Pro · Liquid Retina"),
            ("Kingston","Fury Beast DDR5 32GB","Жедел жад",52000,"RAM",0,"DDR5 · 6000 MT/s"),("G.Skill","Trident Z5 Neo 64GB","Жедел жад",109000,"RAM",0,"DDR5 · 6000 MT/s"),("Corsair","Vengeance DDR5 32GB","Жедел жад",59000,"RAM",0,"DDR5 · 5600 MT/s"),("Kingston","Fury Beast DDR4 32GB","Жедел жад",39000,"RAM",0,"DDR4 · 3600 MT/s"),
            ("Samsung","990 PRO 2TB NVMe","SSD",99000,"SSD",0,"2 TB · PCIe 4.0"),("WD","Black SN850X 1TB","SSD",57000,"SSD",0,"1 TB · PCIe 4.0"),("Kingston","KC3000 2TB","SSD",79000,"SSD",0,"2 TB · PCIe 4.0"),("Crucial","T500 1TB","SSD",53000,"SSD",0,"1 TB · PCIe 4.0"),
            ("ASUS","ROG Swift OLED PG27AQDP","Мониторлар",529000,"",0,"27 inch · OLED · 480 Hz"),("LG","UltraGear 27GS95QE","Мониторлар",399000,"",0,"27 inch · OLED · 240 Hz"),("Samsung","Odyssey G8 34 inch","Мониторлар",469000,"",0,"34 inch · QD-OLED · 175 Hz"),("AOC","Q27G3XMN","Мониторлар",159000,"",0,"27 inch · QHD · 180 Hz"),
            ("Keychron","Q1 Max Wireless","Периферия",119000,"",0,"75% · Hot-swap · Wireless"),("Logitech","G Pro X TKL Lightspeed","Периферия",109000,"",0,"TKL · Wireless"),("Razer","DeathAdder V3 Pro","Периферия",72000,"",0,"63 g · Wireless"),("Logitech","G Pro X Superlight 2","Периферия",79000,"",0,"60 g · Wireless"),("SteelSeries","Arctis Nova 7","Периферия",99000,"",0,"Wireless · 38 h"),("HyperX","Cloud III Wireless","Периферия",79000,"",0,"Wireless · 120 h"),
            ("ASUS","ROG Strix X870E-E Gaming WiFi","Аналық платалар",299000,"Motherboard",0,"AM5 · ATX · DDR5"),("MSI","MAG X870 Tomahawk WiFi","Аналық платалар",199000,"Motherboard",0,"AM5 · ATX · DDR5"),("Gigabyte","B850 AORUS Elite WiFi7","Аналық платалар",159000,"Motherboard",0,"AM5 · ATX · DDR5"),("ASUS","TUF Gaming B650M-Plus","Аналық платалар",119000,"Motherboard",0,"AM5 · mATX · DDR5"),("MSI","Z890 Gaming Plus WiFi","Аналық платалар",179000,"Motherboard",0,"LGA1851 · ATX · DDR5"),("ASRock","B760M Pro RS","Аналық платалар",89000,"Motherboard",0,"LGA1700 · mATX · DDR5"),
            ("Lian Li","O11 Vision Compact","Корпустар",109000,"Case",0,"ATX · GPU 408 mm · Cooler 167 mm"),("Fractal Design","North XL","Корпустар",139000,"Case",0,"ATX · GPU 413 mm · Cooler 185 mm"),("NZXT","H7 Flow","Корпустар",99000,"Case",0,"ATX · GPU 400 mm · Cooler 185 mm"),("Fractal Design","Pop Mini Air","Корпустар",59000,"Case",0,"mATX · GPU 365 mm · Cooler 170 mm"),
            ("Seasonic","Vertex GX-1000","Қуат көздері",139000,"PSU",1000,"1000 W · 80+ Gold"),("Corsair","RM850x Shift","Қуат көздері",119000,"PSU",850,"850 W · 80+ Gold"),("be quiet!","Pure Power 12 M 750W","Қуат көздері",79000,"PSU",750,"750 W · 80+ Gold"),("DeepCool","PN650M","Қуат көздері",59000,"PSU",650,"650 W · 80+ Gold"),
            ("Arctic","Liquid Freezer III 360","Салқындатқыштар",69000,"Cooler",0,"AM5, LGA1851 · 360 mm"),("Noctua","NH-D15 G2","Салқындатқыштар",79000,"Cooler",0,"AM5, LGA1851 · 168 mm"),("DeepCool","AK620 Digital","Салқындатқыштар",49000,"Cooler",0,"AM5, LGA1851 · 162 mm"),("Thermalright","Peerless Assassin 120 SE","Салқындатқыштар",27000,"Cooler",0,"AM5, LGA1851 · 155 mm")
        };
        return rows.Select((r, i) => new Product { Id = i + 1, Brand = r.Brand, Name = r.Name, Category = r.Category, Price = r.Price, OldPrice = i % 6 == 0 ? r.Price * 1.12m : null, IsAvailable = i % 11 != 0, IsFeatured = i < 8, IsNew = i < 6, Description = $"{r.Brand} компаниясының {r.Name} құрылғысы. Күнделікті жұмыс пен жоғары өнімді жүйелерге арналған." , Specifications = r.Specs, ImageUrl = $"/images/product-{(i % 8) + 1}.svg", ComponentType = string.IsNullOrWhiteSpace(r.Type) ? null : r.Type, Wattage = r.Watts, Specs = Structured(r.Type, r.Specs) }).ToList();
    }

    private static Dictionary<string, string> Structured(string type, string specs)
    {
        var d = new Dictionary<string, string>();
        if (type is "CPU" or "Motherboard") d["socket"] = specs.Contains("AM5") ? "AM5" : specs.Contains("LGA1851") ? "LGA1851" : specs.Contains("LGA1700") ? "LGA1700" : "";
        if (type is "RAM" or "Motherboard") d["memory"] = specs.Contains("DDR5") ? "DDR5" : specs.Contains("DDR4") ? "DDR4" : "";
        if (type == "Motherboard") d["formFactor"] = specs.Contains("mATX") ? "mATX" : specs.Contains("ATX") ? "ATX" : "";
        if (type == "Case") { d["formFactor"] = specs.Contains("mATX") ? "mATX" : "ATX"; d["gpuLength"] = System.Text.RegularExpressions.Regex.Match(specs, @"GPU (\d+)").Groups[1].Value; d["coolerHeight"] = System.Text.RegularExpressions.Regex.Match(specs, @"Cooler (\d+)").Groups[1].Value; }
        if (type == "GPU") d["length"] = System.Text.RegularExpressions.Regex.Match(specs, @"(\d+) мм").Groups[1].Value;
        if (type == "Cooler") { d["socketSupport"] = specs.Split('·')[0].Trim(); d["height"] = System.Text.RegularExpressions.Regex.Match(specs, @"(\d+) mm").Groups[1].Value; }
        return d;
    }
}
