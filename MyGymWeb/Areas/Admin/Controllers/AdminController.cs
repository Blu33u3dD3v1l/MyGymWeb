using Microsoft.AspNetCore.Mvc;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
