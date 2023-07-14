using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using System.Diagnostics;
using static MyGymWeb.Areas.Admin.AdminConstants;

namespace MyGymWeb.Controllers
{

   
    public class HomeController : Controller
    {

        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Index", "Admin", new { area = AreaName });
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}