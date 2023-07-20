using Microsoft.AspNetCore.Identity;


namespace MyGymWeb.Data.Models
{
    public class ApplicationUser : IdentityUser
    {


        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public decimal Amount { get; set; } = 1000;

        public List<UserProduct> UsersProducts { get; set; } = new List<UserProduct>();
    }
}
