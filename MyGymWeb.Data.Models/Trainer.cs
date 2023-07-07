using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ClasicTrainerValidations;


namespace MyGymWeb.Data.Models
{
    public class Trainer
    {


        public Trainer()
        {
            this.Gyms = new List<Gym>();
        }

        [Key]
        public Guid Id { get; set; }


       
        [MaxLength(NameMaxValidation)]
        [Required]
        
        public string Name { get; set; } = null!;

        
        [MaxLength(InfoMaxValidation)]
        [Required]
        public string Info { get; set; } = null!;


        [Required]
        public string ImageUrl { get; set; } = null!;

       
        [MaxLength(PractisMaxValidation)]
        [Required]
        public string Practis { get; set; } = null!;

        [Range(typeof(decimal), PriceMaxValidation, PriceMinValidation)]
        [Required]
        public decimal PricePerHour { get; set; }

        [Required]
        public string Type { get; set; } = null!;
      
        [MaxLength(MotoMaxValidation)]
        public string Moto { get; set; } = null!;

        public string? UserId { get; set; }

        public IdentityUser? User { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsAvailable = true;

        public virtual List<Gym> Gyms { get; set; }
       
    }
}
