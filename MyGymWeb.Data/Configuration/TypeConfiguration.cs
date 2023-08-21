using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGymWeb.Data.Configuration
{
   
    internal class TypeConfiguration : IEntityTypeConfiguration<Models.Type>
    {
        public void Configure(EntityTypeBuilder<Models.Type> builder)
        {
            builder
              .HasData(CreateTypes());            

        }
        private List<Models.Type> CreateTypes()
        {
            var types = new List<Models.Type>()
            {
                new Models.Type()
              {
                  Id = 1,
                  Name = "Pilates"
              },            
              new Models.Type()
              {
                  Id = 2,
                  Name = "Yoga"
              },
           
              new Models.Type()
              {
                  Id = 3,
                  Name = "Classic"
              },
              new Models.Type()
              {
                  Id = 4,
                  Name = "Boxing"
              }
            };

            return types;
        }
    }
}
