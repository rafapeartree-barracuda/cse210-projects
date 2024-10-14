using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;
    // ORDEr    
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        total += customer.IsInUSA() ? 5 : 35;
        //$"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}\n=================================="
        return total;
    }
    public double GetTotalProductPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        return total;
    }
    public double GetTotalShippingPrice()
    {
        double total = 0;
        total += customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (var product in products)
        {
            label.AppendLine(product.GetProductInfo());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}\n==================================";
    }
}
