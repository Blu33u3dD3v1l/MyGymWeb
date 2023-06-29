using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using System.Security.Cryptography.X509Certificates;

namespace MyGymWeb.Services
{
    public class GymService : IGymService
    {
        private readonly MyGymProjectDbContext context;

        public GymService(MyGymProjectDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<GymsViewModel>> GetAllGymsAsync()
        {
            var entity = await context.Gyms
            .ToListAsync();

            return entity.Select(g => new GymsViewModel()
            {

                Id = g.Id,
                Name = g.Name,
                Description = g.Description,
                ImageUrl = g.ImageUrl,
                Type = g.Type

            });
        }

        public async Task<IEnumerable<IndexViewModel>> GetAllGymsForIndexAsync()
        {
            var allGyms = await context.Gyms
                .Select(x => new IndexViewModel()
                {
                    Id = x.Id,
                    Type = x.Type,
                    ImageUrl= x.ImageUrl,

                }).ToListAsync();

            return allGyms;
        }

      

       

        public async Task<GymsViewModel> GetDescriptionAsync(int gymId)
        {
            var currId = await context.Gyms.FindAsync(gymId);

            if(currId == null)
            {
                throw new ArgumentNullException("Id Not Found!");
            }


            var entity = new GymsViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                Description = currId.Description,
                ImageUrl = currId.ImageUrl,
                Type = currId.Type
            };                                                                                                                                                                                             

            return entity;
        }

        public async Task<ProductViewModel> GetProductDescriptionAsync(int productId)
        {
            var currId = await context.Products.FindAsync(productId);

            if (currId == null)
            {
                throw new ArgumentNullException("Id Not Found!");
            }

            var entity = new ProductViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                ImageUrl = currId.ImageUrl,
                Description = currId.Description,
                Mark = currId.Mark,
                Price = currId.Price,
            };

            return entity;
        }

       
    }
}

