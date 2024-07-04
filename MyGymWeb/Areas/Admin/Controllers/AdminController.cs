using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services;
using MyGymWeb.Services.Interface;


namespace MyGymWeb.Areas.Admin.Controllers
{

    public class AdminController : BaseController
    {
        private readonly IGymService gymService;

        public AdminController(IGymService _gymService)
            => gymService = _gymService;
        public async Task<IActionResult> Index()
        {

            var statistics = await gymService.GetCountAsync();
            return View(statistics);
        }
     
    }
}
