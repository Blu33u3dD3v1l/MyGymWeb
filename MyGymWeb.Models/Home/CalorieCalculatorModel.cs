using System.ComponentModel.DataAnnotations;

namespace MyGymWeb.Models.Home
{
    public class CalorieCalculatorModel
    {

        [Required]
        public string Gender { get; set; } = "Male";

        [Required]
        [Range(0, 99)]
        public int Age { get; set; }

        [Required]
        [Range(0, 250)]
        public int Height { get; set; }

        [Required]
        [Range(0, 250)]
        public int Weight { get; set; }

        [Required]
        public string ActivityLevel { get; set; } = "Sedentary";
        public int DailyCalories { get; set; }

    }

}
