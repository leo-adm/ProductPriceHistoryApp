using Domain.AggregatesModel;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductPriceHistoryContext _context;

        public ProductsRepository(ProductPriceHistoryContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products
                .Include(x => x.PriceRegisters)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products
                .Include(x => x.PriceRegisters)
                .ToListAsync();
        }

        public async Task RegisterPrice(PriceRegister priceRegister, int id)
        {
            var product = await GetProduct(id);

            product.PriceRegisters.Add(priceRegister);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
