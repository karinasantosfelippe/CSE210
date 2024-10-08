/*
Author: Karina Santos Felippe
*/
namespace Foundation2;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("1661 Driftwood Road", "San Jose", "California", "US");
        Address address2 = new("1165 Werninger Street", "Houston", "Texas", "US");
        Address address3 = new("4659 Heritage Drive", "Calgary", "Alberta", "CN");

        Customer customer1 = new("John", address1);
        Customer customer2 = new("Nala", address2);
        Customer customer3 = new("Lisa", address3);

        Product product1 = new("Laptop", "B001", 1200.00);
        Product product2 = new("Smartphone", "S5241", 999.99, 1);
        Product product3 = new("Monitor", "SF576", 547.25, 2);
        Product product4 = new("USB Type C cable", "C0147", 1.20, 5);
        Product product5 = new("Headphone", "B005", 50.10, 3);

        Order order0 = new(customer3);
        order0.AddProduct(product5);
        order0.AddProduct(product4);
        order0.AddProduct(product1);
        Order order1 = new(customer1, product1);
        order1.AddProduct(product3);
        Order order2 = new(customer2, [product2, product3, product4]);

        List<Order> orders = [order0, order1, order2];

        Console.Clear();
        foreach (var order in orders)
        {
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("\nOrder:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"Total: $ {order.CalculateTotalCost().ToString("F")}.\n");
            Console.WriteLine("--------------------");
        }
        Console.ReadLine();
    }
}