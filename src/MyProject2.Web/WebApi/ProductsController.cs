using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject2.Products;
using MyProject2.Web.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject2.Web.WebApi
{
    [Route("api/[controller]")]
    public class ProductsController : MyProject2ControllerBase
    {
        private readonly ProductAppService _productAppService;

        public ProductsController(ProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            return await _productAppService.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
