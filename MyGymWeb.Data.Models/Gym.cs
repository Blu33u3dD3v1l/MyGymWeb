using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyGymWeb.Common.Constants.ValidationConstants.GymValidations;

namespace MyGymWeb.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Gym
    {

        public Gym()
        {          
            this.GroupsEvents = new List<GroupEvents>();
            this.Products = new List<Product>();

        }


        [Key]
        public int Id { get; set; }

        [MaxLength(NameMaxValidation)]
        [Required]
        public string Name { get; set; } = null!;

        [MaxLength(TypeMaxValidation)]
        [Required]
        public string Type { get; set; } = null!;

        [MaxLength(DesriptionMaxValidation)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Trainer))]
        public Guid? TrainerId { get; set; }

        public Trainer? Trainer { get; set; }

        [ForeignKey(nameof(Athlete))]
        public string? AthleteId { get; set; }

        public ApplicationUser? Athlete { get; set; }

        public virtual IList<GroupEvents> GroupsEvents { get; set; }

        public virtual IList<Product> Products { get; set; }

      

    }
}
