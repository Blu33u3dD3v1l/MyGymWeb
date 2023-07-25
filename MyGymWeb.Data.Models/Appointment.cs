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
        [MaxLength(ClientNameMaxValidation)]
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

        public Guid? TrainerId { get; set; }

        [ForeignKey(nameof(TrainerId))]
        public Trainer? Trainer { get; set; }


    }
}
