using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Admin
{
    public interface IUserService
    {
        Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();


    }
}
