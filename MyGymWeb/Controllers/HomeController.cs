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
       
      
    }
}