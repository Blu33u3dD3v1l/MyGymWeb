using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;


namespace MyGymWeb.Data.Configuration
{
    internal class AdminConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        private readonly RoleManager<IdentityRole> roleManager;

        public AdminConfiguration(RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
        }
     
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
             .HasData(SeedAdmin());
        }

        private List<ApplicationUser> SeedAdmin()
        {
            var types = new List<ApplicationUser>()
            {
                new ApplicationUser()
              {
                 FirstName = "George",
                 LastName = "Bush",
                 Email = "Gosho@abv.bg",
                 UserName = "Gosho@abv.bg"

              }
             

        };

            return types;
        }
    }
}
