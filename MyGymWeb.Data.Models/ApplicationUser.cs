using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.UserValidations;



namespace MyGymWeb.Data.Models
{  
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.UsersProducts = new List<UserProduct>();
            this.UsersTrainers = new List<UserTrainer>();
        }

        [MaxLength(UserFirstNameMaxValidation)]
        public string? FirstName { get; set; }

        [MaxLength(UserLastNameMaxValidation)]
        public string? LastName { get; set; }

        [Required]
        public decimal Amount { get; set; } = 1000;

        public bool UseCode { get; set; }

        [Range(1.0, 10000.0)]
        [Required]
        public decimal DiscountPrice { get; set; }

        public List<UserProduct> UsersProducts { get; set; }
        public List<UserTrainer> UsersTrainers { get; set; }
    }
}
