using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Infrastructure.Extensions.ClaimsExtensions;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;
using MyGymWeb.Services.Models.Trainer;

namespace MyGymWeb.Controllers
{
    [Authorize]
    public class TrainerController : Controller
    {

        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService _trainerService)
        {
            trainerService = _trainerService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Search([FromQuery] AllTrainersQueryModel model)
        {
            var serviceModel
               = await this.trainerService.AllAsync(model);

            model.Trainers = serviceModel.Trainers;
            model.TotalTrainers = serviceModel.TotalTrainersCount;

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]      
        
        public async Task<IActionResult> All()
        {

            var t = await trainerService.GetAllTrainersAsync();
            return this.View(t);
        }

        [AllowAnonymous]
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


        public async Task<IActionResult> Quit(TrainerQuitViewModel model)
        {

            var currentId = User.GetId();


            if (currentId != null)
            {
                await this.trainerService.QuitTrainerAsync(currentId, model);
            }

            TempData[SuccessMessage] = "You successfuly apply for quit!";

            return RedirectToAction("All", "Trainer");
        }
   
    }
}
