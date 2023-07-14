using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    [Authorize]
    public class GymController : Controller
    {
        private readonly IGymService gymService;

        public GymController(IGymService _gymService)
            => gymService = _gymService;

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await gymService.GetAllGymsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await gymService.GetDescriptionAsync(id);

            return View(model);
        }

       
    }
}
