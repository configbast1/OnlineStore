using System;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Laptop", 25000, 5);
            Product p2 = new Product(2, "Mouse", 500, 10);

            Customer c1 = new Customer(1, "Ivan", "ivan@example.com");

            Order o1 = new Order(1, c1);
            o1.AddProduct(p1);
            o1.AddProduct(p2);

            c1.AddOrder(o1);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(c1);
            Console.WriteLine(o1);
        }
    }
}
