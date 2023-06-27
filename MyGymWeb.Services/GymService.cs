using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

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
    }
}

