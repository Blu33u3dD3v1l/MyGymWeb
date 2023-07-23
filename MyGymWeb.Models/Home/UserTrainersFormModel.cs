namespace MyGymWeb.Models.Home
{
    public class UserTrainersFormModel
    {
        public string UserId { get; set; } = null!;
        public string AppointmentTime { get; init; } = null!;

        public string ClientFullName { get; init; } = null!;

        public string Email { get; init; } = null!;

        public string TrainerName { get; init; } = null!;

        public Guid? TrainerId { get; init; }
    }
}
