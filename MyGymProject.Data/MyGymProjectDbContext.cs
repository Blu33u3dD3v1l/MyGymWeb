using MyGymWeb.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Models;

namespace MyGymWeb.Data
{
    public class MyGymProjectDbContext : IdentityDbContext<IdentityUser>
    {
        public MyGymProjectDbContext(DbContextOptions<MyGymProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trainer> Trainers { get; set; } = null!;

        public DbSet<GroupEvents> GroupEvents { get; set; } = null!;

        public DbSet<GroupTrainerName> GroupTrainerNames { get; set; } = null!;

        public DbSet<Gym> Gyms { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Models.Type> Types { get; set; } = null!;

        public DbSet<GymUser> GymsUsers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<All>()
               .HasKey(x => new { x.GymId, x.TrainerId, x.ProductId, });
            base.OnModelCreating(builder);

            builder.Entity<GymUser>()
               .HasKey(x => new { x.GymId, x.UserId });
          

            builder.ApplyConfiguration(new TrainerConfiguration());
            builder.ApplyConfiguration(new GroupTrainerNamesConfiguration());
            builder.ApplyConfiguration(new GymConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());


            base.OnModelCreating(builder);


        }
    }
}