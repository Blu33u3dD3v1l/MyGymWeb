using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.GroupEventsValidations;

namespace MyGymWeb.Data.Models
{
    public class GroupEvents
    {
       
        [Key]
        public int Id { get; set; }
        
        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;
     
        [MaxLength(TimeMaxValidation)]
        [Required]
        public string EventTime { get; set; } = null!;

        public int? TypeId { get; set; }
      
        public Type? Type { get; set; } 

        public int? GymId { get; set; }

        public Gym? Gym { get; set; } 
        public int GroupTrainerNamesId { get; set; }

        [Required]
        public GroupTrainerName GroupTrainerNames { get; set; } = null!;

    }
}
