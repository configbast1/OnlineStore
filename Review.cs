using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Review
    {
        private int id;
        private Customer customer;
        private Product product;
        private string comment;
        private int rating;
        private DateTime date;

        public Review(int id, Customer customer, Product product, string comment, int rating)
        {
            this.id = id;
            this.customer = customer;
            this.product = product;
            this.comment = comment;
            this.rating = rating;
            this.date = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Product Product { get => product; set => product = value; }
        public string Comment { get => comment; set => comment = value; }
        public int Rating { get => rating; set => rating = value; }
        public DateTime Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $"Review by {customer.Name} for {product.Name}: {comment}, Rating: {rating}/5, Date: {date}";
        }
    }
}
