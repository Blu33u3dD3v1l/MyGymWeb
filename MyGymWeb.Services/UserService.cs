using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;
using System.Collections.Immutable;


namespace MyGymWeb.Services
{
    public class UserService : IUserService
    {

        private readonly MyGymProjectDbContext data;
        

        public UserService(MyGymProjectDbContext data)
        {
            this.data = data;
 
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;
         

           result = await data.Trainers
                .Select(x => new UserServiceModel()
            {
                UserId = x.UserId,
                Email = x.User.Email,
                FullName = $"{x.User.FirstName} {x.User.LastName}",
                PhoneNumber = x.PhoneNumber,


            }).ToListAsync();

            string[] trainerIds = result.Select(x => x.UserId).ToArray();
            result.AddRange(await data.Users
                .Where(u => trainerIds.Contains(u.Id) == false)
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}",

                })
                .ToListAsync());

            return result;
        }

        public async Task<string> UserFullName(string userId)
        {
           var user = await data.Users
                .FirstOrDefaultAsync(x => x.Id == userId);

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}
