using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class GymController : BaseController
    {
        private readonly IGymService gymService;

        public GymController(IGymService _gymService)
            => gymService = _gymService;

        [HttpGet]
        public async Task<IActionResult> ManageGym()
        {
            var model = await gymService.GetAllGymsAsync();

            return View(model);
        }

        [HttpGet]
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
                TempData[SuccessMessage] = "You successfuly edited a Gym!";

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("ManageGym", "Gym", "Admin");
        }


        [HttpGet]
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
            TempData[SuccessMessage] = "You successfuly added a Gym!";
            return RedirectToAction("ManageGym", "Gym", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await gymService.RemoveGymAsync(id);
            TempData[SuccessMessage] = "You successfuly deleted a Gym!";
            return RedirectToAction("ManageGym", "Gym", "Admin");
        }
    }
}
