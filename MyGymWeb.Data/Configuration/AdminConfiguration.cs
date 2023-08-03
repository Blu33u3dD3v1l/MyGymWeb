using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;


namespace MyGymWeb.Data.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    internal class AdminConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
           .HasData(SeedAdmin());
        }

        private ApplicationUser SeedAdmin()
        {

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            var admin = new ApplicationUser()
            {
                Id = "bdb57211-855c-470a-b0f4-817d9335a26b",
                UserName = "Admin@admin.bg",
                NormalizedUserName = "Admin@admin.bg",
                Email = "Admin@admin.bg",
                NormalizedEmail = "Admin@admin.bg",
                FirstName = "George",
                LastName = "Bush"
            };

            admin.PasswordHash = hasher.HashPassword(admin, "Viktor123!");
            
            return admin;
        }


    }
}
