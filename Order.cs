using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnlineStore
{
    internal class Order
    {
        private int id;
        private Customer customer;
        private List<Product> products;
        private DateTime date;

        public Order(int id, Customer customer)
        {
            this.id = id;
            this.customer = customer;
            products = new List<Product>();
            date = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public List<Product> Products { get => products; }
        public DateTime Date { get => date; }

        public void AddProduct(Product product)
        {
            if (product != null)
                products.Add(product);
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var p in products)
            {
                total += p.Price;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Order {id} for {customer.Name}, Total: {TotalPrice():C}, Products: {products.Count}, Date: {date}";
        }
    }
}