using MyGymProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGymProject.Data.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
           .HasData(CreateProduct());
        }

        private List<Product> CreateProduct()
        {
            var product = new List<Product>()
          {
            new Product()
            {
                Id = 1,
                Name = "Wolves Fitness Shaker Bottle",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0572/7397/4993/products/ShakerBanner_1_1080x.jpg?v=1676866459",
                Mark = "WolvesFitness",
                Price = 30,
                Description = "Introducing our sleek and stylish protein shaker bottle - the perfect companion for your workouts and active lifestyle!, Crafted with a perfect size.",


            },
            new Product()
            {
                Id = 2,
                Name = "Urban Fitness 2in1 Protein Shaker",
                ImageUrl = "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276",
                Mark = "Urban Fitness",
                Price = 27,
                Description = "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.",


            },
             new Product()
             {
                 Id = 3,
                 Name = "The Fitness Gloves",
                 ImageUrl = "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288",
                 Mark = "ElephantSkin Fitness",
                 Price = 17,
                 Description = "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.",


             },
              new Product()
              {
                  Id = 4,
                  Name = "Pro Nutrition and Fitness",
                  ImageUrl = "https://cdn.shopify.com/s/files/1/0233/6459/9885/products/51v0EC9aP5L._SL1080.jpg?v=1666270776",
                  Mark = "Goodlife",
                  Price = 50,
                  Description = "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india",


              },
                new Product()
                {
                    Id = 5,
                    Name = "L-Carnitine",
                    ImageUrl = "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg",
                    Mark = "Goodlife",
                    Price = 14,
                    Description = "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.",


                }
            };
            return product;
       }
                       
    }
}
