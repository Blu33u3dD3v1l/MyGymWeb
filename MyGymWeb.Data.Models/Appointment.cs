using static MyGymWeb.Common.Constants.ValidationConstants.AppointmentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGymWeb.Data.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentTime { get; set; } 

        [Required]
        public string ClientFullName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(TrainerNameMaxValidation)]

        public string TrainerName { get; set; } = null!;

        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

        [ForeignKey(nameof(Trainer))]
        public Guid? TrainerId { get; set; }
      
        public Trainer? Trainer { get; set; }


    }
}
