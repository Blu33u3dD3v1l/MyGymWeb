using Microsoft.AspNetCore.Mvc;


namespace MyGymWeb.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
       
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
