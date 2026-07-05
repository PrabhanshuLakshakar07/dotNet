using System;
using System.Collections.Generic;

namespace ConsoleEcommercePractice
{
    // 1. Pehle humne wahi Product Model banaya jo MVC me chahiye tha
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }

    class Program
    {
        // Practice ke liye temporary database (List)
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000, StockQuantity = 10 },
            new Product { Id = 2, Name = "Mobile", Price = 15000, StockQuantity = 25 }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- E-COMMERCE PRACTICE MENU ---");
                Console.WriteLine("1. Saare Products Dekhein (GET)");
                Console.WriteLine("2. Naya Product Add Karein (POST)");
                Console.WriteLine("3. Exit");
                Console.Write("Apna option chunein (1-3): ");

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    ShowProducts();
                }
                else if (choice == "2")
                {
                    AddProduct();
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Galat option! Fir se try karein.");
                }
            }
        }

        // --- MOCK GET ACTION ---
        static void ShowProducts()
        {
            Console.WriteLine("\n--- PRODUCT LIST ---");
            Console.WriteLine("ID\tNaam\t\tPrice\tStock");
            Console.WriteLine("-------------------------------------");
            foreach (var p in _products)
            {
                Console.WriteLine($"{p.Id}\t{p.Name}\t\t₹{p.Price}\t{p.StockQuantity}");
            }
        }

        // --- MOCK POST ACTION ---
        static void AddProduct()
        {
            Console.WriteLine("\n--- NAYA PRODUCT ADD KAREIN ---");
            Product newProduct = new Product();

            // ID auto increment logic
            newProduct.Id = _products.Count + 1;

            Console.Write("Product ka Naam dalein: ");
            newProduct.Name = Console.ReadLine() ?? "";

            Console.Write("Product ki Price dalein: ");
            newProduct.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Stock Quantity dalein: ");
            newProduct.StockQuantity = Convert.ToInt32(Console.ReadLine());

            // List me save kar diya (Jaise database me karte hain)
            _products.Add(newProduct);
            Console.WriteLine("🎉 Product successfully add ho gaya!");
        }
    }
}