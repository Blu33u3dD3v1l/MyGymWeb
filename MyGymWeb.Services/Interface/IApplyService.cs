using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IApplyService
    {

        Task AddApplyAsync(string userId, AddTrainerFormModel model);
        Task<IEnumerable<TrainerViewModel>> GetAllAppliesAsync();
        Task<TrainerViewModel> GetDeleteAppliersAsync(Guid id, TrainerViewModel model);
        Task DeleteAppliersAsync(Guid id);
        Task ApproveTrainerAsync(Guid id);
        Task<bool>  ApplierExistByUserId(string userId);


    }
}
