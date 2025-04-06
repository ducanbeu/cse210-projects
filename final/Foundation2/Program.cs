using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>{
            new Product("Water", 1234, 1, 2),
            new Product("Ice", 2345, 2, 3),
            new Product ("Snow", 3456, 4, 5)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("2 Center St", "Orem", "UT", "EU");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> products2 = new List<Product>{
            new Product("Not Water", 4567, 6, 7),
            new Product("Not Ice", 5678, 8, 9),
            new Product ("Not Snow", 6789, 10, 11)
        };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("----------------");
        Console.WriteLine("Packing Label:");
        order1.DisplayPackingLabel();
        Console.WriteLine("Shipping Label:");
        order1.DisplayShippingLabel();
        Console.WriteLine("Price:");
        Console.WriteLine("$" + order1.GetTotalCost());
        Console.WriteLine("----------------");

        Console.WriteLine("----------------");
        Console.WriteLine("Packing Label:");
        order2.DisplayPackingLabel();
        Console.WriteLine("Shipping Label:");
        order2.DisplayShippingLabel();
        Console.WriteLine("Price:");
        Console.WriteLine("$" + order2.GetTotalCost());
        Console.WriteLine("----------------");
    }
}