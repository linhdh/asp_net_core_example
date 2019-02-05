using MyProject2.Models;
using MyProject2.Products;
using System.Collections.Generic;

namespace MyProject2.Web.Models
{
    public class ProductListViewModel
    {
        public List<ProductDto> ProductDtos { get; }

        public ProductListViewModel(List<ProductDto> productdtos)
        {
            ProductDtos = productdtos;
        }
    }
}
