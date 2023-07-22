using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.UserValidations;


namespace MyGymWeb.Data.Models
{
    public class ApplicationUser : IdentityUser
    {

        [MaxLength(UserFirstNameMaxValidation)]
        public string? FirstName { get; set; }

        [MaxLength(UserLastNameMaxValidation)]
        public string? LastName { get; set; }

        [Required]
        public decimal Amount { get; set; } = 1000;

        public List<UserProduct> UsersProducts { get; set; } = new List<UserProduct>();
        public List<UserTrainer> UsersTrainers { get; set; } = new List<UserTrainer>();
    }
}
