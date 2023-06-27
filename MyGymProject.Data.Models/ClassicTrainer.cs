using System.ComponentModel.DataAnnotations;
using static MyGymProject.Common.Constants.ValidationConstants.ClasicTrainerValidations;

namespace MyGymProject.Data.Models
{
    public class ClassicTrainer
    {

       

        [Key]
        public int Id { get; set; }


       
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

        [Range(1.00, 200.00)]
        [Required]
        public decimal PricePerHour { get; set; }

       
        [MaxLength(MotoMaxValidation)]
        public string Moto { get; set; } = null!;

        public List<All> All { get; set; } = new List<All>();
    }
}
