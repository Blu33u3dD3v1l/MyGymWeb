using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyGymWeb.Models.Home
{
   
    public class TrainerQuitViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string Info { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public string Practis { get; set; } = null!;

        public decimal PricePerHour { get; set; }

     
        public string Type { get; set; } = null!;


        public string Motto { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string? UserId { get; set; }

        public IdentityUser? User { get; set; }

        public string? ForApplication { get; set; }
    }
}
