namespace InventoryManagementSystem
{
    internal class Program
    {

         const int MaxProducts = 100;
         static string[,] products = new string[MaxProducts,3];
         static int productCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my inventory management system!..");
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
                    // Code to view all products goes here
                    break;
                case 3:
                    Console.WriteLine("You chose to update a product.");
                    // Code to update a product goes here
                    break;
                case 4:
                    Console.WriteLine("You chose to delete a product.");
                    // Code to delete a product goes here
                    break;
                case 5:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
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
    }
}
