using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IProductService
    {

        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel> GetProductDescriptionAsync(int id);
        Task<TestViewModel> GetEditProductAsync(int id);
        Task EditByIdAsync(int id, TestViewModel model);
        Task AddProductsAsync(AddProductsFormModel model);
        Task DeleteProductAsync(int id);
       

    }
}
