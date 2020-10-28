
using Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task SaveChanges();
        Task RegisterPrice(PriceRegister priceRegister, int id);
    }
}
