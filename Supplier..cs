using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Supplier
    {
        private int id;
        private string name;
        private List<Product> products;

        public Supplier(int id, string name)
        {
            this.id = id;
            this.name = name;
            products = new List<Product>();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Product> Products { get => products; }

        public void AddProduct(Product product)
        {
            if (product != null)
                products.Add(product);
        }

        public override string ToString()
        {
            return $"Supplier: {name}, Products: {products.Count}";
        }
    }
}