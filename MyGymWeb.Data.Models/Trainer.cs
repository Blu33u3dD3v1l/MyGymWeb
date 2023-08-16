using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyGymWeb.Common.Constants.ValidationConstants.ClasicTrainerValidations;


namespace MyGymWeb.Data.Models
{
    public class Trainer
    {
      

        public Trainer()
        {
            this.Gyms = new List<Gym>();
            this.Appointments = new List<Appointment>();
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
        public string Motto { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsAvailable = true;

        public virtual List<Gym> Gyms { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}

