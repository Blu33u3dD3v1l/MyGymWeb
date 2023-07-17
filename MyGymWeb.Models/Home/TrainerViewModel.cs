using Microsoft.AspNetCore.Identity;


namespace MyGymWeb.Models.Home
{
    public class TrainerViewModel 
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Info { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Practis { get; set; } = null!;

        public decimal PricePerHour { get; set; }

        public string? PhoneNumber { get; set; }
        public string Moto { get; set; } = null!;
        public string Type { get; set; } = null!;
        public bool IsAvailable { get; set; }
        public string? UserId { get; set; }
       public IdentityUser? User { get; set; }
    }
}
