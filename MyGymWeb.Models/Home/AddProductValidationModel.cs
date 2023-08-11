using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ProductValidations;

namespace MyGymWeb.Models.Home
{
    public class AddProductValidationModel
    {

        [StringLength(MarkMaxValidation, MinimumLength = MarkMinValidation)]
        [Required]
        public string Mark { get; set; } = null!;

        [StringLength(NameMaxValidation, MinimumLength = NameMinValidation)]
        [Required]
        public string Name { get; set; } = null!;

        [Range(1.0, 2000.0)]
        [Required]
        public decimal Price { get; set; }

        [StringLength(DescriptionMaxValidation, MinimumLength = DescriptionMinValidation)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}
