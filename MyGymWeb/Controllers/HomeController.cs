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

        public IActionResult Error(int statusCode)
        {


            if(statusCode == 400)
            {
                return View("Error400");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
       
      
    }
}