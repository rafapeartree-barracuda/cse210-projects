using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

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
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
    }
}
