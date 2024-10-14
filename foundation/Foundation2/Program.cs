using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("444 50th street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Cley", address1);

        Address address2 = new Address("Rua Perdizes, 888", "Cuiaba", "MT", "Brasil");
        Customer customer2 = new Customer("Maria Souza", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 800, 1));
        order1.AddProduct(new Product("Mouse", "B456", 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C789", 500, 1));
        order2.AddProduct(new Product("Charger", "D012", 25, 3));

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nProduct Total: ${order.GetTotalProductPrice():0.00}");
        Console.WriteLine($"Shipping Total: ${order.GetTotalShippingPrice():0.00}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
        Console.ResetColor();
        Console.WriteLine();
    }
}
