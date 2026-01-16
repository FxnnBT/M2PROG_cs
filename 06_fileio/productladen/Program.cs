namespace productladen;

using System.Net.Http.Headers;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        Program RunProducten = new Program();
        RunProducten.RunProducten();
    }

    internal void Run()
    {
        
        string text = File.ReadAllText("Product.json");
        Product product = JsonSerializer.Deserialize<Product>(text);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine(product.Price);
    }
    internal void RunProducten()
    {
        string text = File.ReadAllText("Producten.json");
        Product[] products = JsonSerializer.Deserialize<Product[]>(text);
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
        }
    }
}
