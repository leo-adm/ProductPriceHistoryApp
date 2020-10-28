using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.PriceRegister
{
    public class PriceRegisterReadModel
    {
        public double Price { get; set; }
        public string Date { get; set; }
        public string Seller { get; set; }
    }
}
