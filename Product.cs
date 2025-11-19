using System;
using System.Collections.Generic;
using System.Globalization;
namespace OnlineStore
{
    internal class Product
    {
        private int id;
        private string name;
        private decimal price;
        private int stock;

        public Product(int id, string name, decimal price, int stock = 0)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public int Stock
        {
            get => stock;
            set => stock = value;
        }

        public void Restock(int amount)
        {
            if (amount > 0)
                stock += amount;
        }

        public bool Sell(int amount)
        {
            if (amount <= stock)
            {
                stock -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            CultureInfo culture = new CultureInfo("uk-UA"); 
            return $"Product: {name}, Price: {price.ToString("C", culture)}, Stock: {stock}";
        }
    }
}
