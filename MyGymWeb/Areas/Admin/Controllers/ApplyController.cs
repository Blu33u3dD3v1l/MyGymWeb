using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.ObjectModelRemoting;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Services.Admin;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class ApplyController : BaseController
    {

        private readonly IApplyService applyService;

        public ApplyController(IApplyService _applyService)
        {
            applyService = _applyService;
        }

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

            return RedirectToAction("All", "Apply", "Admin");
        }

        public async Task<IActionResult> Approve(Guid id)
        {
          
            await this.applyService.ApproveTrainerAsync(id);
            await this.applyService.DeleteAppliersAsync(id);

            return RedirectToAction("All", "Apply", "Admin");
        }

    }
}
