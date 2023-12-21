using Staj.Core.Dtos;
using Staj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponceDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
