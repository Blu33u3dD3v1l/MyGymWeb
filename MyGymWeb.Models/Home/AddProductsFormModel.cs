using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ProductValidations;

namespace MyGymWeb.Models.Home
{
    public class AddProductsFormModel
    {

        [MaxLength(MarkMaxValidation)]
        [Required]
        public string Mark { get; set; } = null!;

        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;

        [Range(1.0, 200.0)]
        [Required]
        public int Price { get; set; }

        [MaxLength(DescriptionMaxValidation)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}
