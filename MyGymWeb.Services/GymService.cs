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

        public async Task AddGymAsync(AddGymFormModel model)
        {
            var entity = new Gym()
            {
               Name = model.Name,
               ImageUrl = model.ImageUrl,
               Description = model.Description,
               Type = model.Type,
            };

            
            await context.Gyms.AddAsync(entity);
            await context.SaveChangesAsync();
            
        }

        public async Task DeleteGymAsync(int id)
        {
           var gym = await context.Gyms
                .FirstAsync(x => x.Id == id);

           context.Gyms.Remove(gym); 
           await context.SaveChangesAsync();
        }

        public async Task EditByIdAsync(int id,EditGymFormModel model)
        {
            var currGym = await context.Gyms.
               FirstOrDefaultAsync(x => x.Id == id);

            if (currGym == null)
            {
                throw new Exception();
            }

            currGym.Id = id;
            currGym.Name = model.Name;
            currGym.Description = model.Description;
            currGym.ImageUrl = model.ImageUrl;
            currGym.Type = model.Type;

            await this.context.SaveChangesAsync();

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

      

       

        public async Task<GymsViewModel> GetDescriptionAsync(int id)
        {
            var currId = await context.Gyms.FindAsync(id);

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

        public async Task<EditGymFormModel> GetEditGymAsync(int id)
        {
            var currGym = await context.Gyms.
               FirstOrDefaultAsync(x => x.Id == id);

            if (currGym == null)
            {
                throw new Exception();
            }

            return new EditGymFormModel()
            {
                Id = currGym.Id,
                Name = currGym.Name,
                ImageUrl = currGym.ImageUrl,               
                Type = currGym.Type,
                Description = currGym.Description
            };
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

