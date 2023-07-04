using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using System.Diagnostics;

namespace MyGymWeb.Controllers
{

   
    public class HomeController : Controller
    {
        private readonly IGymService gymService;

        public HomeController(IGymService _gymService)
        {
            gymService = _gymService;
        }


        public async Task<IActionResult> Index()
        {


            var entity = await gymService.GetAllGymsForIndexAsync();
            return View(entity);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}