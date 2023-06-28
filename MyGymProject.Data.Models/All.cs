namespace MyGymWeb.Data.Models
{
    public class All
    {

        public int GymId { get; set; } 

        public Gym Gym { get; set; } = null!;

        public int TrainerId { get; set; }   

        public Trainer Trainer { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

    }
}
