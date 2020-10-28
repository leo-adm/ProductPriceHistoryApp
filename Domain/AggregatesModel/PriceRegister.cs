using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregatesModel
{
    public class PriceRegister
    {
        public PriceRegister(int id, double price, DateTime date, string seller)
        {
            Id = id;
            Price = price;
            Date = date;
            Seller = seller;
        }
        public PriceRegister() { }
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public double Price { get; private set; }
        public DateTime Date { get; private set; }
        public string Seller { get; private set; }
    }
}
