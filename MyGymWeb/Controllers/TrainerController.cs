using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class TrainerController : Controller
    {

        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService _trainerService)
        {
            trainerService = _trainerService;
        }


        public async Task<IActionResult> All()
        {
            var t = await trainerService.GetAllTrainersAsync();
            return View(t);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid trainerId)
        {
            var model = await trainerService.GetTrainerDescriptionAsync(trainerId);

            return View(model);
        }

        public async Task<IActionResult> TrainerView(int gymId)
        {
            var t = await trainerService.GetTypeTrainersAsync(gymId);
            return View(t);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var view = await trainerService.GetEditTrainerAsync(id);
            return View(view);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, EditTrainerFormModel model)
        {
           if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainerService.EditByIdAsync(id, model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Trainer");
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddTrainerFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTrainerFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainerService.AddTrainerAsync(model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Trainer");


        }

    }
}
