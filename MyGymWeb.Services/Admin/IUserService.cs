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
        Task AddAppointmentAsync(Guid trainerId, string userId, AppointmentFormModel model);
        Task<bool> AppointmentExistByUserId(string userId, Guid id);     
        Task<IEnumerable<UserTrainersFormModel>> GetMyTrainersAsync(string userId);
        Task CancelUserApplicationAsync(int id);
        Task<IEnumerable<TrainerViewModel>> GetAllMyTrainersAsync(string userId);
        Task BuyProducts(int productId, string userId);
        Task Code (string userId, string code);
        Task<IEnumerable<DiscountViewModel>> GetAllProductsForRefresh(string userId);

    }
}
