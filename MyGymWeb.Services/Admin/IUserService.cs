using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Admin
{
    public interface IUserService
    {

        Task<string> UserFullName(string userId);
        Task<IEnumerable<UserServiceModel>> All();
        Task BuyProductAsync(int id, string userId);
        Task<IEnumerable<ProductViewModel>> GetAllProductsForBuyAsync(string userId);
        Task ReturnProductAsync(string userId, int id);
        //Task DeleteUserAsync(string id);

    }
}
