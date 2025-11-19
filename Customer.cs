using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Customer
    {
        private int id;
        private string name;
        private string email;
        private List<Order> orders;

        public Customer(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            orders = new List<Order>();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public List<Order> Orders { get => orders; }

        public void AddOrder(Order order)
        {
            if (order != null)
                orders.Add(order);
        }

        public override string ToString()
        {
            return $"Customer: {name}, Email: {email}, Orders: {orders.Count}";
        }
    }
}