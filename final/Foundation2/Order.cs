using System;
using System.Text;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.GetTotalCost();
        }
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (var product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString().Trim();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}