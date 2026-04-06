📦 Inventory Management System

A simple, clean, and Object-Oriented C# Console Application for managing product inventory.
This project demonstrates the fundamentals of OOP, Lists, validation, and CRUD operations.

✨ Features

✔ Add a new product
✔ View all products
✔ Update an existing product
✔ Delete a product
✔ Auto-generated product IDs
✔ Fully OOP (Product class + clean program structure)
✔ Input validation for safety
✔ Simple and beginner-friendly console UI

🧱 Project Structure
InventoryManagementSystem/
│
├── Program.cs
│   • Contains main loop and menu handling
│   • Implements Add / View / Update / Delete logic
│
└── Product.cs
    • Product model with Name, Price, Quantity
🛠 Technology Used
C# (.NET Console)
OOP (Classes, Objects)
List<T>
Input Validation (TryParse)
Switch-case menu control
▶️ How to Run the Project

1️⃣ Open the project folder in Visual Studio or VS Code
2️⃣ Run this command:

dotnet run

3️⃣ Choose an action from the menu and start managing products 🎉

📌 How It Works
➕ Add Product
User enters product name, price, and quantity
The system validates input
A new Product object is added to the List
📋 View Products

Displays all products with an auto-generated ID:

ID: 1 | Name: Laptop | Price: 15000 | Qty: 5
✏️ Update Product
User enters the ID
System updates name, price, and quantity
❌ Delete Product
Removes the product from the List by ID
