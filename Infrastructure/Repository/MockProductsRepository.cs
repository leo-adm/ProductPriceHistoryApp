using Domain.AggregatesModel;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MockProductsRepository : IProductsRepository
    {
        public async Task SaveChanges()
        {
            await new Task(() => { });
        }

        public async Task<List<Product>> GetProducts()
        {
            await new Task(() => { });

            var list = new List<PriceRegister> { new PriceRegister(0, 10.99, DateTime.Now, "KABUM!") };

            return new List<Product>
            {
                new Product(1, "Product 1", list),
                new Product(2, "Product 2", new List<PriceRegister>()),
                new Product(3, "Product 3", new List<PriceRegister>())
            };
        }

        public async Task<Product> GetProduct(int id)
        {
            await new Task(() => { });

            return new Product(1, "Product 1", new List<PriceRegister>());
        }

        public async Task AddProduct(Product product)
        {
            await new Task(() => { });
        }

        public async Task UpdateProduct(Product product)
        {
            await new Task(() => { });
        }

        public async Task RegisterPrice(PriceRegister priceRegister, int id)
        {
            await new Task(() => { });
        }
    }
}
