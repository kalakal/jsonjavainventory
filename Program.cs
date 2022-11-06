using System;
using System.Text.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace seriailzepr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = JsonSerializer.Serialize(new Product().GetProducts());
            Console.WriteLine("json object \n");
            Console.WriteLine(json);
            Console.WriteLine("d-serialized json object");
            var products = JsonSerializer.Deserialize < ObservableCollection<Product<>>(json);
            products.Tolist().forEach(p => Console.WriteLine(p.Name));

        }
    }
    public class Product
    {
        public string Name { get; set; }

        public double PricePerKg { get; set; }

        public int Weight { get; set; }

        public ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>();
            {
                new Product() { Name = "Rice", PricePerKg = 36.99, Weight = 1 };
                new Product() { Name = "Pulses", PricePerKg = 54.99, Weight = 2 };
                new Product() { Name = "Wheat", PricePerKg = 32.99, Weight = 5 };
            };
        }
    }
}
