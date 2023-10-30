using MyGymWeb.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Models;


namespace MyGymWeb.Data
{
    public class MyGymProjectDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
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

        public DbSet<Apply> Applies { get; set; } = null!;

        public DbSet<Appointment> Appointments { get; set; } = null!;

        public DbSet<UserProduct> UsersProducts { get; set; } = null!;

        public DbSet<UserTrainer> UsersTrainers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserProduct>()
               .HasKey(x => new { x.UserId, x.ProductId });

            builder.Entity<UserTrainer>()
              .HasKey(x => new { x.UserId, x.TrainerId });

            builder.Entity<Gym>()
                .HasOne(x => x.Trainer)
                .WithMany(y => y.Gyms)
                .HasForeignKey(x => x.TrainerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Appointment>()
           .HasOne(a => a.Trainer) 
           .WithMany(t => t.Appointments) 
           .HasForeignKey(a => a.TrainerId)
           .OnDelete(DeleteBehavior.NoAction);


            builder.ApplyConfiguration(new GroupTrainerNamesConfiguration());
            builder.ApplyConfiguration(new GymConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());
            builder.ApplyConfiguration(new TrainerConfiguration());
            builder.ApplyConfiguration(new AdminConfiguration());

            base.OnModelCreating(builder);

        }
       
    }
}