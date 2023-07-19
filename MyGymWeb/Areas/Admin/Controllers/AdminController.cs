using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
