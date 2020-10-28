using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.PriceRegister
{
    public class PriceRegisterCreateModel
    {
        [Required]
        public double Price { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public string Seller { get; set; }
    }
}
