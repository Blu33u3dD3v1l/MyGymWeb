using Microsoft.AspNetCore.Identity;

namespace MyGymWeb.Data.Models
{
    public class GymUser
    {

        public string UserId { get; set; } = null!; 

        public IdentityUser User { get; set; } = null!;

        public int GymId { get; set; }

        public Gym Gym { get; set; } = null!;


    }
}
