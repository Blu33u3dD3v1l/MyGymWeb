namespace MyGymWeb.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserTrainer
    {
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        public Guid TrainerId { get; set; }

        public Trainer Trainer { get; set; } = null!;
    }
}
