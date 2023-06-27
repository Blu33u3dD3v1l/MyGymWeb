using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class GymController : Controller
    {
        private readonly IGymService gymService;

        public GymController(IGymService _gymService)
            => gymService = _gymService;

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await gymService.GetAllGymsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int gymId)
        {
            var model = await gymService.GetDescriptionAsync(gymId);

            return View(model);
        }
    }
}
