using MyGymProject.Data.Configuration;
using MyGymProject.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyGymProject.Data
{
    public class MyGymProjectDbContext : IdentityDbContext<IdentityUser>
    {
        public MyGymProjectDbContext(DbContextOptions<MyGymProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<BoxingTrainer> BoxingTrainers { get; set; } = null!;

        public DbSet<ClassicTrainer> ClassicTrainers { get; set; } = null!;

        public DbSet<GroupEvents> GroupEvents { get; set; } = null!;

        public DbSet<GroupTrainerName> GroupTrainerNames { get; set; } = null!;

        public DbSet<Gym> Gyms { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Models.Type> Types { get; set; } = null!;

        public DbSet<GymUser> GymsUsers { get; set; } = null!;




        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<All>()
                .HasKey(x => new { x.GymId, x.BoxingTrainerId, x.ClassicTrainerId, x.ProductId, });
            base.OnModelCreating(builder);

            builder.Entity<GymUser>()
               .HasKey(x => new { x.GymId, x.UserId });
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BoxingTrainerConfiguration());
            builder.ApplyConfiguration(new ClassicTrainerConfiguration());
            builder.ApplyConfiguration(new GroupTrainerNamesConfiguration());
            builder.ApplyConfiguration(new GymConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());

        }
    }
}