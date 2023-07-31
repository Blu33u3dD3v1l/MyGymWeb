using MyGymWeb.Data.Models;
using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.UserValidations;


namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>

    public class RegisterFormModel
    {
       
        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
