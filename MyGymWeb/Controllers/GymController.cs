using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
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
        public async Task<IActionResult> Details(int id)
        {
            var model = await gymService.GetDescriptionAsync(id);

            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var view = await gymService.GetEditGymAsync(id);
            return View(view);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditGymFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.gymService.EditByIdAsync(id, model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Gym");
        }

    }
}
