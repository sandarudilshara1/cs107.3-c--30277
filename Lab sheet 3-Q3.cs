using System;

class Product
{
    // Fields
    private int productId;
    private string productName;
    private double price;
    private int quantityInStock;

    // Constructor
    public Product(int productId, string productName, double price, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantityInStock = quantityInStock;
    }

    // Method to add product (not specified in the requirements, but included for completeness)
    public void AddProduct(int quantityToAdd)
    {
        quantityInStock += quantityToAdd;
        Console.WriteLine($"{quantityToAdd} {productName}(s) added to inventory.");
    }
    // Method to buy product
    public void BuyProduct(int quantityToBuy)
    {
        if (quantityToBuy <= 0)
        {
            Console.WriteLine("Quantity to buy must be greater than zero.");
            return;
        }

        if (quantityToBuy > quantityInStock)
        {
            Console.WriteLine("Insufficient quantity in stock.");
        }
        else
        {
            quantityInStock -= quantityToBuy;
            Console.WriteLine($"{quantityToBuy} {productName}(s) bought successfully.");
        }
    }

    // Method to display product information
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Quantity in Stock: {quantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Product class
        Product laptop = new Product(101, "Laptop", 800, 10);

        // Display product information
        laptop.DisplayProductInfo();

        // Attempt to modify the product's ID from external code
        // This will result in a compile-time error because productId has private access
        // laptop.productId = 102; // Uncommenting this line will cause a compilation error
    }
}












