using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.GroupTrainerNamesValidation;

namespace MyGymWeb.Data.Models
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
