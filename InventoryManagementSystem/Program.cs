namespace InventoryManagementSystem
{
    internal class Program
    {

        const int MaxProducts = 100;
        static string[,] products = new string[MaxProducts, 3];
        static int productCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my inventory management system!..");

            while (true)
            {
                Console.WriteLine("============================================\n");
                Console.WriteLine("Enter your choice from the following list:\n");
                Console.WriteLine("1. Add a new product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Update a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Exit");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You chose to add a new product.");
                        AddProduct();
                        break;
                    case 2:
                        Console.WriteLine("You chose to view all products.");
                        ViewProducts();
                        break;
                    case 3:
                        Console.WriteLine("You chose to update a product.");
                        //UpdateProduct();
                        break;
                    case 4:
                        Console.WriteLine("You chose to delete a product.");
                        DeleteProduct();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine()!;

            Console.WriteLine("Enter product price:");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter product quantity:");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            products[productCount, 0] = productName;
            products[productCount, 1] = productPrice.ToString();
            products[productCount, 2] = productQuantity.ToString();

            productCount++;

            Console.WriteLine($"Product '{productName}' added successfully with price {productPrice} and quantity {productQuantity}.");
        }

        private static void ViewProducts()
        {
            if (productCount == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }
            Console.WriteLine("Product List:");
            Console.WriteLine("-------------");
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($" ID: {i + 1}, Name: {products[i, 0]}, Price: {products[i, 1]}, Quantity: {products[i, 2]}");
            }
        }

        private static void DeleteProduct()
        {
            Console.WriteLine("Enter the ID of the product to delete:");
            int productId = Convert.ToInt32(Console.ReadLine());
            if (productId < 1 || productId > productCount)
            {
                Console.WriteLine("Invalid product ID.");
                return;
            }
            for (int i = productId - 1; i < productCount - 1; i++)
            {
                products[i, 0] = products[i + 1, 0];
                products[i, 1] = products[i + 1, 1];
                products[i, 2] = products[i + 1, 2];
            }
            productCount--;
            Console.WriteLine($"Product with ID {productId} deleted successfully.");
        }
        
    }
}
