using Newtonsoft.Json;
using System.Data.SqlTypes;

class Product
{
    public double Weight { get; set; }
    public decimal Price { get; set; }
    public double Volume { get; set; }
    public string Name { get; set; }
    public bool Fragile { get; set; }

    public Product(double weight, decimal price, double volume, string name, bool fragile)
    {
        Weight = weight;
        Price = price;
        Volume = volume;
        Name = name;
        Fragile = fragile;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product(1.5, 150m, 0.5, "Яблоко", true));
        products.Add(new Product(2.0, 200m, 1.0, "Апельсин", false));
        products.Add(new Product(2.5, 35m, 0.5, "Сок", true));
        products.Add(new Product(0.1, 99m, 0.1, "Шоколад", true));
        products.Add(new Product(1.5, 100m, 1.0, "Лимонад", true));
        products.Add(new Product(0.5, 300m, 1.0, "Кофе", false));
        products.Add(new Product(0.5, 150m, 0.5, "Какао", true));
        products.Add(new Product(2.0, 150m, 2.0, "Печенье", false));
        products.Add(new Product(1.0, 150m, 0.5, "Добрый кола", true));
        products.Add(new Product(0.5, 100m, 1.0, "Пломбир", false));

        foreach (Product product in products)
        {
            Console.WriteLine($"Наименование: {product.Name}, Цена: {product.Price}, Вес: {product.Weight}, Объем: {product.Volume}, Хрупкий: {product.Fragile}");
        }

        string json = JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(json);
    }
}
