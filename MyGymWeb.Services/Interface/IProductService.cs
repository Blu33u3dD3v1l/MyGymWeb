using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IProductService
    {

        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel> GetProductDescriptionAsync(int productId);
        Task<TestViewModel> GetEditProductAsync(int productId);
    }
}
