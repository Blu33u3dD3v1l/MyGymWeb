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

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var products = await context.Products
               .Select(x => new ProductViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Description = x.Description,
                   Mark = x.Mark,
                   Price = x.Price,

               }).ToListAsync();

            return products;
        }

        public async Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync()
        {
            var trainers = await context.Trainers
               .Select(x => new TrainerViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Info = x.Info,
                   Moto = x.Moto,
                   Practis = x.Practis,
                   PricePerHour = x.PricePerHour,

               }).ToListAsync();

            return trainers;
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

        public async Task<TrainerViewModel> GetTrainerDescriptionAsync(int trainerId)
        {
            var currId = await context.Trainers.FindAsync(trainerId);

            if (currId == null)
            {
                throw new ArgumentNullException("Id Not Found!");
            }

            var entity = new TrainerViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                ImageUrl= currId.ImageUrl,
                Moto = currId.Moto,
                Info = currId.Info,
                Practis = currId.Practis,
                PricePerHour = currId.PricePerHour,
            };

            return entity;
        }
    }
}

