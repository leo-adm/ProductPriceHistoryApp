using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class ProductPriceHistoryContext : DbContext
    {
        public ProductPriceHistoryContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
