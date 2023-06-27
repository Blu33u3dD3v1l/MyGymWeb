using System.ComponentModel.DataAnnotations;
using static MyGymProject.Common.Constants.ValidationConstants.GroupTrainerNamesValidation;

namespace MyGymProject.Data.Models
{
    public class GroupTrainerName
    {

        [Key]
        public int Id { get; set; }

     
        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;
    }
}
