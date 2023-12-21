using AutoMapper;
using Staj.Core.Dtos;
using Staj.Core.Entities;
using Staj.Core.Repositories;
using Staj.Core.Services;
using Staj.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> genericRepository, IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }

        public Task<CustomResponceDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
