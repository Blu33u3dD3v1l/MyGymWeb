using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Controllers
{
    public class CalorieCalculatorController : Controller
    {
        private readonly ICalorieCalculatorService calorieService;
        public CalorieCalculatorController(ICalorieCalculatorService calorieService)
        {
            this.calorieService = calorieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalorieCalculatorModel());
        }

        [HttpPost]
        public IActionResult Index(CalorieCalculatorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Height == 0 || model.Weight == 0 || model.Age == 0)
            {
                ModelState.AddModelError(string.Empty, "Please enter valid data.");

            }
            else
            {
                model.DailyCalories = calorieService.CalculateCalories(
                    model.Gender, model.Age, model.Height, model.Weight, model.ActivityLevel);

            }
            return View(model);

        }

    }
}
