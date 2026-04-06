using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    internal class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");

            while (true)
            {
                ShowMenu();

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ViewProducts();
                        break;
                    case "3":
                        UpdateProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        Console.WriteLine("Exiting program... Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Update a product");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=======================================\n");
        }

        static void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter product price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            Console.Write("Enter product quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity))
            {
                Console.WriteLine("Invalid quantity!");
                return;
            }

            products.Add(new Product(name, price, quantity));
            Console.WriteLine($"Product '{name}' added successfully!");
        }

        static void ViewProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\n--- Product List ---");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(
                    $"ID: {i + 1} | Name: {products[i].Name} | Price: {products[i].Price} | Qty: {products[i].Quantity}");
            }
        }

        static void UpdateProduct()
        {
            Console.Write("Enter product ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 1 || id > products.Count)
            {
                Console.WriteLine("Invalid ID!");
                return;
            }

            var product = products[id - 1];

            Console.Write("Enter new product name: ");
            string newName = Console.ReadLine()!;

            Console.Write("Enter new price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal newPrice))
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            Console.Write("Enter new quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int newQty))
            {
                Console.WriteLine("Invalid quantity!");
                return;
            }

            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQty;

            Console.WriteLine("Product updated successfully!");
        }

        static void DeleteProduct()
        {
            Console.Write("Enter product ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 1 || id > products.Count)
            {
                Console.WriteLine("Invalid ID!");
                return;
            }

            products.RemoveAt(id - 1);
            Console.WriteLine("Product deleted successfully!");
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}