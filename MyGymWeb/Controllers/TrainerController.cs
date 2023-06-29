using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Details(int trainerId)
        {
            var model = await trainerService.GetTrainerDescriptionAsync(trainerId);

            return View(model);
        }

        public async Task<IActionResult> TrainerView(int gymId)
        {
            var t = await trainerService.GetTypeTrainersAsync(gymId);
            return View(t);
        }

    }
}
