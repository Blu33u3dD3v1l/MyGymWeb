using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGymService gymService;

        public ProductController(IGymService _gymService)
            => gymService = _gymService;

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await gymService.GetAllProductsAsync();

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int productId)
        {
            var model = await gymService.GetProductDescriptionAsync(productId);

            return View(model);
        }

    }
}
