using Microsoft.AspNetCore.Mvc;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
