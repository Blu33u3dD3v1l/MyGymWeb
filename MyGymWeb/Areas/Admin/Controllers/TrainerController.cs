using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;



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
       
        public async Task<IActionResult> ManageTrainer()
        {          
                var t = await trainerService.GetAllTrainersAsync();
                return View(t);
            
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

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        }

        //[HttpGet]

        //public async Task<IActionResult> Delete(Guid id, TrainerDetailsRemoveViewModel model)
        //{
        //    string? userId = this.User.GetId();

        //    if (userId == null)
        //    {
        //        return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        //    }

        //    bool isTrainer = await this.trainerService.TrainerExistByUserId(userId);

        //    if (!isTrainer)
        //    {
        //        return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        //    }


        //    bool isTrue = await this.trainerService.GetTrainerUserId(id, userId);
        //    if (isTrue)
        //    {
        //        var a = await trainerService.GetForDeleteAsync(id, model);
        //        return View(a);
        //    }
        //    return RedirectToAction("ManageTrainer", "Trainer", "Admin");

        //}

       
        public async Task<IActionResult> Delete(Guid id)
        {
            //string? userId = this.User.GetId();

            //if (userId == null)
            //{
            //    return RedirectToAction("ManageTrainer", "Trainer", "Admin");
            //}

            //bool isTrainer = await this.trainerService.TrainerExistByUserId(userId);

            //if (!isTrainer)
            //{
            //    return RedirectToAction("ManageTrainer", "Trainer", "Admin");
            //}


            //bool isTrue = await this.trainerService.GetTrainerUserId(id, userId);
           
                await trainerService.DeleteTrainerAsync(id);
            
            return RedirectToAction("ManageTrainer", "Trainer", "Admin");
        }
    }
}
