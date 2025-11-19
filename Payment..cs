using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Payment
    {
        private int id;
        private decimal amount;
        private string method;
        private DateTime date;

        public Payment(int id, decimal amount, string method)
        {
            this.id = id;
            this.amount = amount;
            this.method = method;
            this.date = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string Method { get => method; set => method = value; }
        public DateTime Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $"Payment {id}, Amount: {amount:C}, Method: {method}, Date: {date}";
        }
    }
}
