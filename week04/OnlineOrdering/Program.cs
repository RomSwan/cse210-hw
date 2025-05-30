using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1
        Address address1 = new Address("3013 Brookview Drive", "Houston", "TX", "USA");
        Customer customer1 = new Customer("Hulk Hogan", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Belt", "BL0001", 299.99, 1));
        order1.AddProduct(new Product("Chair", "CH3983", 15.99, 6));

        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine("------------------------\n");

        //Customer 2
        Address address2 = new Address("ul. Jagiellońska 62", "Rzeszów", "Podkarpackie", "Poland");
        Customer customer2 = new Customer("Katarzyna Wiśniewska", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Guitar Strings", "GS1930", 11.99, 2));
        order2.AddProduct(new Product("Guitar Picks", "GP8324", 0.59, 20));

        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");

        Console.WriteLine("------------------------\n");
    }
}