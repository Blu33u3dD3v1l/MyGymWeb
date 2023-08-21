using Microsoft.AspNetCore.Mvc;
using static MyGymWeb.Web.Extensions.Extensions.AdminConstants;

namespace MyGymWeb.Controllers
{

    public class HomeController : Controller
    {

        
        public IActionResult Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
               return RedirectToAction("Index", "Admin", new { area = AreaName });
            }
            return View();
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