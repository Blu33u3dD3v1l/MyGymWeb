namespace MyGymWeb.Models.Home
{
    public class UserTrainersFormModel
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public string AppointmentTime { get; set; } = null!;

        public string ClientFullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string TrainerName { get; set; } = null!;

        public Guid? TrainerId { get; set; }
    }
}
