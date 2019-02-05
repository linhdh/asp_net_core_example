using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject2.Models;
using MyProject2.Products;
using MyProject2.Web.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyProject2.Web.Controllers
{
    public class HomeController : MyProject2ControllerBase
    {
        private readonly ProductAppService _productAppService;

        public HomeController(ProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Upload(List<IFormFile> files)
        {
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var stream = formFile.OpenReadStream();
                    StreamReader reader = new StreamReader(stream);
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] parts = line.Split(",");
                        var product = new Product(int.Parse(parts[0]), parts[1], parts[2], float.Parse(parts[3]), parts[4], uint.Parse(parts[5]));
                        await _productAppService.Create(product);
                    }
                }
            }
            return Redirect("ProductList");
        }

        public async Task<ActionResult> ProductList()
        {
            var productdtos = await _productAppService.GetAll();
            return View(new ProductListViewModel(productdtos));
        }

        public ActionResult About()
        {
            return View();
        }
    }
}