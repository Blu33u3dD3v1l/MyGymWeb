using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using System.Runtime.InteropServices;

namespace MyGymWeb.Controllers
{
    public class ApplyController : Controller
    {
        private readonly IApplyService applyService;

        public ApplyController(IApplyService _applyService)
        {
            applyService = _applyService;
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(AddTrainerFormModel model)
        {

            var currentId = User.GetId();
            if(currentId != null)
            {
                await this.applyService.AddApplyAsync(currentId, model);
            }
          

            return RedirectToAction("All", "Trainer");
        }


    }
}
