using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class ShoppingCart
    {
        private Customer customer;
        private List<Product> items;

        public ShoppingCart(Customer customer)
        {
            this.customer = customer;
            items = new List<Product>();
        }

        public Customer Customer { get => customer; }
        public List<Product> Items { get => items; }

        public void AddItem(Product product)
        {
            if (product != null)
                items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            if (product != null)
                items.Remove(product);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var p in items)
                total += p.Price;
            return total;
        }

        public override string ToString()
        {
            return $"Shopping Cart for {customer.Name}, Items: {items.Count}, Total: {Total():C}";
        }
    }
}
