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

        public IActionResult Add()
        {
            var model =  new AddGymFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddGymFormModel model)
        {
            if(!ModelState.IsValid)
            {
                throw new Exception();
            }

          
                await gymService.AddGymAsync(model);
                return RedirectToAction("All", "Gym");
        }
    }
}
