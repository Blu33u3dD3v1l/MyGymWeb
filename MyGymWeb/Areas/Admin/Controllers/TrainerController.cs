using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;



namespace MyGymWeb.Areas.Admin.Controllers
{
    public class TrainerController : BaseController
    {
        private readonly ITrainerService trainerService;
        private readonly IApplyService applyService;
      

        public TrainerController(ITrainerService _trainerService, IApplyService _applyService)
        {
            trainerService = _trainerService;
            applyService = _applyService;
        }

        [HttpGet]

        public async Task<IActionResult> ManageTrainer()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            try
            {
                var t = await trainerService.GetAllTrainersAsync();
                return View(t);
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddTrainerFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            string? userId = this.User.GetId();

            try
            {
                if (userId != null)
                {
                    bool isTrainer = await this.trainerService.TrainerExistByUserId(userId);

                    if (isTrainer)
                    {
                        return RedirectToAction("ManageTrainer", "Trainer", "Admin");
                    }
                }

                await this.trainerService.AddTrainerAsync(model);

                TempData[SuccessMessage] = "You successfuly added a trainer!";
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }
          

            return RedirectToAction("ManageTrainer", "Trainer", "Admin");
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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainerService.EditByIdAsync(id, model);
                TempData[SuccessMessage] = "You Successfuly edited a trainer!";

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

            return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {


            await trainerService.DeleteTrainerAsync(id);

            TempData[SuccessMessage] = "You successfuly removed a trainer!";

            return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteForApply(Guid id)
        {


            await trainerService.DeleteTrainerForApplyAsync(id);
            await applyService.DeleteAppliersAsync(id);

            TempData[SuccessMessage] = "You successfuly removed a trainer!";

            return RedirectToAction("All", "Apply", "Admin");
        }

    }
}
