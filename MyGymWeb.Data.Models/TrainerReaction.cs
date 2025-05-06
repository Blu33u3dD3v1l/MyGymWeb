namespace MyGymWeb.Data.Models
{
    public class TrainerReaction
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public Guid TrainerId { get; set; }
        public bool IsLike { get; set; } 
    }
}
