namespace MyGymWeb.Models.Home
{
   
    public class AppointmentFormModel
    {
        public int Id { get; set; }
        public DateTime AppointmentTime { get; set; }

        public string ClientFullName { get; set; } = null!;

        public string Email { get; set; } = null!;
  
        public string TrainerName { get; set; } = null!;
        public Guid? TrainerId { get; set; }
      


    }
}
