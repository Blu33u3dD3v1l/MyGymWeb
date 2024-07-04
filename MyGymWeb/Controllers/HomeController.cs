using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;
using static MyGymWeb.WebExtensions.AdminConstants;


namespace MyGymWeb.Controllers
{

    public class HomeController : Controller
    {

        private readonly IGymService gymService;

        public HomeController(IGymService _gymService)
            => gymService = _gymService;
        public async  Task<IActionResult> Index()
        { 

            var statistics = await gymService.GetCountAsync();
            
            if (User.IsInRole(AdminRolleName))
            {
               return RedirectToAction("Index", "Admin", new { area = AreaName });
            }
            return View(statistics);
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {

            if(statusCode == 404)
            {
                return this.View("Error404");
            }
            if (statusCode == 401)
            {
                return this.View("Error401");
            }

            return View();
        }

    }
}