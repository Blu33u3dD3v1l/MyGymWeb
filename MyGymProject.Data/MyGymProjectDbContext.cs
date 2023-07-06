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

       


        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Gym>()
                .HasOne(x => x.Trainer)
                .WithMany(y => y.Gyms)
                .HasForeignKey(x => x.TrainerId)
                .OnDelete(DeleteBehavior.Cascade);
           
           builder.ApplyConfiguration(new GroupTrainerNamesConfiguration());
           builder.ApplyConfiguration(new GymConfiguration());
           builder.ApplyConfiguration(new ProductConfiguration());
           builder.ApplyConfiguration(new TypeConfiguration());
           //builder.ApplyConfiguration(new TrainerConfiguration());



            base.OnModelCreating(builder);


        }
    }
}