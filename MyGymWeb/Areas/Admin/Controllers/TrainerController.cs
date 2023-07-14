using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Areas.Admin.AdminConstants;


namespace MyGymWeb.Areas.Admin.Controllers
{
    public class TrainerController : BaseController
    {
        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService _trainerService)
        {
            trainerService = _trainerService;
        }

        [HttpGet]
       
        public async Task<IActionResult> AddTrainer()
        {          
                var t = await trainerService.GetAllTrainersAsync();
                return View(t);
            
        }

    }
}
