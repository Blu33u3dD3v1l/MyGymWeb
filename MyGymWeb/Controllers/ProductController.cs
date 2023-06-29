using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
            => productService = _productService;

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.GetAllProductsAsync();

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int productId)
        {
            var model = await productService.GetProductDescriptionAsync(productId);

            return View(model);
        }

    }
}
