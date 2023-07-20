using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IApplyService
    {

        Task AddApplyAsync(string userId, TrainerQuitViewModel model);
        Task<IEnumerable<TrainerQuitViewModel>> GetAllAppliesAsync();
        Task<TrainerQuitViewModel> GetDeleteAppliersAsync(Guid id, TrainerQuitViewModel model);
        Task DeleteAppliersAsync(Guid id);
        Task ApproveTrainerAsync(Guid id);
        Task<bool>  ApplierExistByUserId(string userId);


    }
}
