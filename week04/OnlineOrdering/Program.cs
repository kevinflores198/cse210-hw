using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Unknown st", "Anywhere", "NY", "USA");
        Customer customer1 = new Customer("Kevin Flores", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("MacBook", "RRTR2345443", 3000.00, 2);
        Product product2 = new Product("Keyboard Apple", "34545TTOFG", 800.00, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal()}");
    }
}