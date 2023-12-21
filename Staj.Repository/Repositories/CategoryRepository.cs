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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x=>x.Products).Where(x=>x.ID==categoryId).SingleOrDefaultAsync();
        }
    }
}
