using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
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

        public async Task AddProductsAsync(AddProductsFormModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Mark = model.Mark,
                Price = model.Price,
                

            };

            await this.context.Products.AddAsync(entity);
            await this.context.SaveChangesAsync();
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

        public async Task<TestViewModel> GetEditProductAsync(int id)
        {
           var currPoduct = await context.Products
                .FirstOrDefaultAsync(x => x.Id == id);

            if (currPoduct == null)
            {

                throw new Exception();
            }

            return new TestViewModel()
            {
                Id = id,
                Name = currPoduct.Name,
                ImageUrl = currPoduct.ImageUrl,
                Description = currPoduct.Description,
                Price = currPoduct.Price,
                Mark = currPoduct.Mark,

            };
        }

        public async Task<ProductViewModel> GetProductDescriptionAsync(int id)
        {
            var currId = await context.Products.FindAsync(id);

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
