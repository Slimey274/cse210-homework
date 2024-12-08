using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Adresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Customer examples
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Product examples
        Product product1 = new Product("Widget", "A001", 10.00, 3);
        Product product2 = new Product("Gadget", "B002", 15.50, 2);
        Product product3 = new Product("Thingamajig", "C003", 7.25, 4);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        // Display order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}