using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;


namespace MyGymWeb.Areas.Admin.Controllers
{
    public class ApplyController : BaseController
    {



        private readonly IApplyService applyService;
       

        public ApplyController(IApplyService _applyService) 
        {
            applyService = _applyService;
            
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await applyService.GetAllAppliesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id, TrainerQuitViewModel model)
        {

            if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var a = await applyService.GetDeleteAppliersAsync(id, model);
                
            }
            catch (ArgumentNullException)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View(model);
            }

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
          
            if(!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                await applyService.DeleteAppliersAsync(id);

                TempData[SuccessMessage] = "You successfuly removed an application!";
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }
            
            

            return RedirectToAction("All", "Apply", "Admin");
        }

      
        public async Task<IActionResult> Approve(Guid id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }


            try
            {
                await this.applyService.ApproveTrainerAsync(id);
                await this.applyService.DeleteAppliersAsync(id);

                TempData[SuccessMessage] = "You successfuly approved a trainer!";
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
                return View();
            }

            return RedirectToAction("All", "Apply", "Admin");
        }

    }
}
