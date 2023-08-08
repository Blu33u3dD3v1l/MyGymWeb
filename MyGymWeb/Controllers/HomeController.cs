using Humanizer.DateTimeHumanizeStrategy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyGymWeb.Data.Models;
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