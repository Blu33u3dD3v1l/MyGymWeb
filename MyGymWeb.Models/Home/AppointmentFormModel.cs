namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>
    public class AppointmentFormModel
    {
        public int Id { get; set; }
        public DateTime AppointmentTime { get; init; }

        public string ClientFullName { get; init; } = null!;

        public string Email { get; init; } = null!;
  
        public string TrainerName { get; init; } = null!;
        public Guid? TrainerId { get; set; }
      


    }
}
