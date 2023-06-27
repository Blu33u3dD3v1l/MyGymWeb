namespace MyGymProject.Data.Models
{
    public class All
    {

        public int GymId { get; set; } 

        public Gym Gym { get; set; } = null!;

        public int BoxingTrainerId { get; set; }

        public BoxingTrainer BoxingTrainer { get; set; } = null!;

        public int ClassicTrainerId { get; set; }   

        public ClassicTrainer ClassicTrainer { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

    }
}
