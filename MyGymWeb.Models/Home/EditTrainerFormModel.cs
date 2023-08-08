using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ClasicTrainerValidations;
namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>
    public class EditTrainerFormModel
    {

        [Key]
        public Guid Id { get; set; }

        [StringLength(NameMaxValidation, MinimumLength = NameMinValidation)]
        [Required]

        public string Name { get; set; } = null!;

        [StringLength(InfoMaxValidation, MinimumLength = InfoMinValidation)]
        [Required]
        public string Info { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;


        [StringLength(PractisMaxValidation, MinimumLength = PractisMinValidation)]
        [Required]
        public string Practis { get; set; } = null!;

        [Range(1.00, 200.00)]
        [Required]
        public decimal PricePerHour { get; set; }

        public string Type { get; set; } = null!;


        [StringLength(MotoMaxValidation, MinimumLength = MotoMinValidation)]
        public string Motto { get; set; } = null!;

        public string? PhoneNumber { get; set; }
    }
}
