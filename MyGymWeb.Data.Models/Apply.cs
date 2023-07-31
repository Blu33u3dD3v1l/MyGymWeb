using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ClasicTrainerValidations;

namespace MyGymWeb.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Apply
    {
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

        public string? PhoneNumber { get; set; }

        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

        public string? ForApplication { get; set; }

        public bool IsActive { get; set; } = true;


        public bool IsAvailable = true;
    }
}
