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
          
            await applyService.DeleteAppliersAsync(id);

            TempData[SuccessMessage] = "You successfuly removed an application!";

            return RedirectToAction("All", "Apply", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Approve(Guid id)
        {
          
            await this.applyService.ApproveTrainerAsync(id);
            await this.applyService.DeleteAppliersAsync(id);
        

            TempData[SuccessMessage] = "You successfuly approved a trainer!";

            return RedirectToAction("All", "Apply", "Admin");
        }

    }
}
