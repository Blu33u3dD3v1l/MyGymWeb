using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ProductValidations;

namespace MyGymWeb.Data.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(MarkMaxValidation)]
        [Required]
        public string Mark { get; set; } = null!;

        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;

        [Range(1.0, 10000.0)]
        [Required]
        public decimal Price { get; set; }

        [MaxLength(DescriptionMaxValidation)]
        [Required]
        public string Description { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public int? GymId { get; set; }
        
        public Gym? Gym { get; set; }    

    }
}
