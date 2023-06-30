using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.GymValidations;

namespace MyGymWeb.Data.Models
{
    public class Gym
    {

        public Gym()
        {
            this.ClassicTrainers = new List<Trainer>();
            this.GroupsEvents = new List<GroupEvents>(); 
            this.Products = new List<Product>(); 
            this.All = new List<All>();          
            this.GymsUsers = new List<GymUser>();
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

        public string ImageUrl { get; set; } = null!;


        public virtual IList<All> All { get; set; }

        public virtual IList<Trainer> ClassicTrainers { get; set; }

        public virtual IList<GroupEvents> GroupsEvents { get; set; }

        public virtual IList<Product> Products { get; set; }

        public virtual IList<GymUser> GymsUsers { get; set; }


    }
}
