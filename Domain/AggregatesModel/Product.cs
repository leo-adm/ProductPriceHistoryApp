using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregatesModel
{
    public class Product
    {
        public Product(int id, string fullName, List<PriceRegister> priceRegisters)
        {
            Id = id;
            FullName = fullName;
            PriceRegisters = priceRegisters;
        }
        public Product() { }
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public List<PriceRegister> PriceRegisters { get; private set; } = new List<PriceRegister>();
    }
}
