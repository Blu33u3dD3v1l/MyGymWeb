using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.UserValidations;



namespace MyGymWeb.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
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

        public List<UserProduct> UsersProducts { get; set; }
        public List<UserTrainer> UsersTrainers { get; set; }
    }
}
