using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;

namespace MyGymWeb.Services
{
    public class UserService : IUserService
    {
        public Task<IEnumerable<UserServiceModel>> All()
        {
            throw new NotImplementedException();
        }

        public Task<string> UserFullName(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
