using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyGymWeb.Models.Home
{
    public class AllTrainersViewModel
    {
              
        public Guid Id { get; set; }
      
        public string Name { get; set; } = null!;
       
        public string Info { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;

        public string Practis { get; set; } = null!;

        [Display(Name = "Hour Price")]
        public decimal PricePerHour { get; set; }
      
        public string Type { get; set; } = null!;

        public string Motto { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public IdentityUser? User { get; set; }

     
    }
}
