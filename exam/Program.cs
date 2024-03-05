

public class InventoryItem
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Constructor
    public InventoryItem(string name, int id, double price, int quantity)
    {
        Name = name;
        ID = id;
        Price = price;
        Quantity = quantity;
    }

    // Methods
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    public void RestockItem(int additionalQuantity)
    {
        Quantity += additionalQuantity;
    }

    public void SellItem(int quantitySold)
    {
        if (quantitySold <= Quantity)
        {
            Quantity -= quantitySold;
        }
        else
        {
            Console.WriteLine("Error: Not enough stock available.");
        }
    }

    public bool IsInStock()
    {
        return Quantity > 0;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}



class Program
{
    static void Main()
    {
        // Example usage
        InventoryItem item1 = new InventoryItem("Product A", 101, 20.99, 50);
        InventoryItem item2 = new InventoryItem("Product B", 102, 15.49, 30);

        Console.WriteLine("Initial Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Update price
        item1.UpdatePrice(22.99);
        Console.WriteLine("\nDetails after price update:");
        item1.PrintDetails();

        // Restock items
        item2.RestockItem(20);
        Console.WriteLine("\nDetails after restocking:");
        item2.PrintDetails();

        // Sell items
        item1.SellItem(10);
        item2.SellItem(25);
        Console.WriteLine("\nDetails after selling items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Check if items are in stock
        Console.WriteLine($"\nIs item1 in stock? {item1.IsInStock()}");
        Console.WriteLine($"Is item2 in stock? {item2.IsInStock()}");
    }
}