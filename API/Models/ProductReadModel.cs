using API.Models.PriceRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Product
{
    public class ProductReadModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<PriceRegisterReadModel> PriceRegisters { get; set; }
    }
}
