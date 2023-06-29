using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Services
{
    public class ProductService : IProductService
    {
        private readonly MyGymProjectDbContext context;

        public ProductService(MyGymProjectDbContext _context)
        {
            context = _context;
        }


        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var products = await context.Products
               .Select(x => new ProductViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Description = x.Description,
                   Mark = x.Mark,
                   Price = x.Price,

               }).ToListAsync();

            return products;
        }

        public async Task<ProductViewModel> GetProductDescriptionAsync(int productId)
        {
            var currId = await context.Products.FindAsync(productId);

            if (currId == null)
            {
                throw new ArgumentNullException("Id Not Found!");
            }

            var entity = new ProductViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                ImageUrl = currId.ImageUrl,
                Description = currId.Description,
                Mark = currId.Mark,
                Price = currId.Price,
            };

            return entity;
        }
    }
}
