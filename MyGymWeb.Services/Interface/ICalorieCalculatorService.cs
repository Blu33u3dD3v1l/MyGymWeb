namespace MyGymWeb.Services.Interface
{
    public interface ICalorieCalculatorService
    {
        int CalculateCalories(string gender, int age, int height, int weight, string activityLevel);
    }

}
