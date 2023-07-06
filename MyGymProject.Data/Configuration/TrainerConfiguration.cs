using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Models;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;


namespace MyGymWeb.Data.Configuration
{
    internal class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder
              .HasData(CreateTypes());


        }
        private List<Trainer> CreateTypes()
        {
            var types = new List<Trainer>()
            {
                new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Alabala",
                  ImageUrl = @".\Images\Image.Jpg.jpg",
                  Info = "gfgfgfgf",
                  Moto = "fdsdsf",
                  Practis = "gfgfgf",
                  Type = "gfgfgfgff",
                  PricePerHour = 200

              }
            };

            return types;
        }

    }
}
