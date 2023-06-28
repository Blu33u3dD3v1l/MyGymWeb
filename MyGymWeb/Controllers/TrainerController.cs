using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class TrainerController : Controller
    {

        private readonly IGymService gymService;

        public TrainerController(IGymService _gymService)
        {
            gymService = _gymService;
        }


        public async Task<IActionResult> All()
        {
            var t = await gymService.GetAllTrainersAsync();
            return View(t);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int trainerId)
        {
            var model = await gymService.GetTrainerDescriptionAsync(trainerId);

            return View(model);
        }

    }
}
