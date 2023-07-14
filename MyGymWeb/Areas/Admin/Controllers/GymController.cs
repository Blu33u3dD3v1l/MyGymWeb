using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class GymController : BaseController
    {
        private readonly IGymService gymService;

        public GymController(IGymService _gymService)
            => gymService = _gymService;

        public async Task<IActionResult> ManageGym()
        {
            var model = await gymService.GetAllGymsAsync();

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

            return RedirectToAction("ManageGym", "Gym", "Admin");
        }



        public IActionResult Add()
        {
            var model = new AddGymFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddGymFormModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }


            await gymService.AddGymAsync(model);
            return RedirectToAction("ManageGym", "Gym", "Admin");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await gymService.RemoveGymAsync(id);
            return RedirectToAction("ManageGym", "Gym", "Admin");
        }
    }
}
