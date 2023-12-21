using Microsoft.EntityFrameworkCore;
using Staj.Core.Entities;
using Staj.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            //Eager Loading yaptık (bilgi=Lazy Loading de var ama burada yok)
            return await _appDbContext.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
