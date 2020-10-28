using API.Models.PriceRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Product
{
    public class ProductCreateModel
    {
        [Required]
        public string FullName { get; set; }
        public List<PriceRegisterCreateModel> PriceRegisters { get; set; } = new List<PriceRegisterCreateModel>();
    }
}
