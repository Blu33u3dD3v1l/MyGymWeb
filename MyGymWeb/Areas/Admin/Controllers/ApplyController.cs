using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;


namespace MyGymWeb.Areas.Admin.Controllers
{
    public class ApplyController : BaseController
    {



        private readonly IApplyService applyService;
        //private readonly RoleManager<IdentityRole> roleManager;

        public ApplyController(IApplyService _applyService) //RoleManager<IdentityRole> roleManager
        {
            applyService = _applyService;
            //this.roleManager = roleManager;
        }

        //public async Task<IActionResult> CreateTrainerRole()
        //{

        //    var currentId = User.GetId();
        //    IdentityRole role = new IdentityRole()
        //    {
        //        Name = "Trainer",

        //    };


        //    await roleManager.CreateAsync(role);


        //    return RedirectToAction("Index", "Home");


        //}

        public async Task<IActionResult> All()
        {
            var model = await applyService.GetAllAppliesAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id, TrainerViewModel model)
        {


            var a = await applyService.GetDeleteAppliersAsync(id, model);
          

            return View(a);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
          
            await applyService.DeleteAppliersAsync(id);

            TempData[SuccessMessage] = "You successfuly removed an application!";

            return RedirectToAction("All", "Apply", "Admin");
        }

        public async Task<IActionResult> Approve(Guid id)
        {
          
            await this.applyService.ApproveTrainerAsync(id);
            await this.applyService.DeleteAppliersAsync(id);
            //await this.CreateTrainerRole();

            TempData[SuccessMessage] = "You successfuly approved a trainer!";

            return RedirectToAction("All", "Apply", "Admin");
        }

    }
}
