using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IProductService
    {

        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel> GetProductDescriptionAsync(int id);
        Task<TestViewModel> GetEditProductAsync(int id);
        Task AddProductsAsync(AddProductsFormModel model);

    }
}
