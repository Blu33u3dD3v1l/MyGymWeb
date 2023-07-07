using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> Details(int id)
        {
            var model = await productService.GetProductDescriptionAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await productService.GetEditProductAsync(id);

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddProductsFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductsFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.productService.AddProductsAsync(model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Product");


        }

    }
}
