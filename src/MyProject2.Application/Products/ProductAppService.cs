using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyProject2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MyProject2.Products
{
    public class ProductAppService : IApplicationService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<ProductGroup> _productGroupRepository;

        public ProductAppService(IRepository<Product> productRepository, IRepository<ProductGroup> productGroupRepository)
        {
            _productRepository = productRepository;
            _productGroupRepository = productGroupRepository;
        }

        public async Task Create(Product product)
        {
            await _productRepository.InsertAsync(product);
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = _productRepository.GetAll();
            var productGroups = _productGroupRepository.GetAll();
            var result = from p in products join pg in productGroups on p.GroupId equals pg.Id select new ProductDto {
                Id = p.Id,
                GroupName = pg.Name, 
                Name = p.Name, 
                Price = p.Price
            };
            return await result.ToListAsync();
        }
    }
}
