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
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> genericRepository, IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(genericRepository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponceDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var product = await _productRepository.GetProductsWithCategory();
            var productsDTo = _mapper.Map<List<ProductWithCategoryDto>>(product);
            return CustomResponceDto<List<ProductWithCategoryDto>>.Success(200, productsDTo);
        }
    }
}
