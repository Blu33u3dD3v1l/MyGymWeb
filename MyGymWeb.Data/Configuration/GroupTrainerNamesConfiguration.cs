using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;

namespace MyGymWeb.Data.Configuration
{
 
    internal class GroupTrainerNamesConfiguration : IEntityTypeConfiguration<GroupTrainerName>
    {
        public void Configure(EntityTypeBuilder<GroupTrainerName> builder)
        {
            builder
            .HasData(CreateGroupTrainers());
        }

        private List<GroupTrainerName> CreateGroupTrainers()
        {
            var groupTrainers = new List<GroupTrainerName>()
            {
             new GroupTrainerName()
             {
                  Id = 1,
                  Name = "Desy Perez"
             },
             new GroupTrainerName()
             {
                 Id = 2,
                 Name = "John Doe"
             },
             new GroupTrainerName()
             {
                 Id = 3,
                 Name = "Kevin Friend"
             }
            };
            return groupTrainers;
        }


    }
 }
