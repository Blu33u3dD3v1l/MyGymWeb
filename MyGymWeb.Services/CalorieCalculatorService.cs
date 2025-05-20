using MyGymWeb.Services.Interface;


namespace MyGymWeb.Services
{
    public class CalorieCalculatorService : ICalorieCalculatorService
    {
        public int CalculateCalories(string gender, int age, int height, int weight, string activityLevel)
        {
            double bmr = gender == "Male"
           ? 10 * weight + 6.25 * height - 5 * age + 5
           : 10 * weight + 6.25 * height - 5 * age - 161;

            double multiplier = activityLevel switch
            {
                "Sedentary" => 1.2,
                "Lightly Active" => 1.375,
                "Moderately Active" => 1.55,
                "Very Active" => 1.725,
                "Extra Active" => 1.9,
                _ => 1.2
            };

            return (int)(bmr * multiplier);

        }
    }
}
