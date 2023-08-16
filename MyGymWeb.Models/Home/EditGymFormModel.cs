using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.GymValidations;

namespace MyGymWeb.Models.Home
{
  
    public class EditGymFormModel
    {


        [Key]
        public int Id { get; set; }

        [StringLength(NameMaxValidation, MinimumLength = NameMinValidation)]
        [Required]
        public string Name { get; set; } = null!;

        [StringLength(TypeMaxValidation, MinimumLength = TypeMinValidation)]
        [Required]
        public string Type { get; set; } = null!;

        [StringLength(DesriptionMaxValidation, MinimumLength = DesriptionMinValidation)]
        [Required]
        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

    }
}
