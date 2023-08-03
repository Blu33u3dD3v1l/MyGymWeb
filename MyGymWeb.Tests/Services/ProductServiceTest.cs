using Moq;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;


namespace MyGymWeb.Tests.Services
{
    public class ProductServiceTest
    {

        [Fact]

        public void AddProductAsyncShouldReturnCorrectView()
        {
           

            using var data = DatabaseMock.Instance;
            AddProductsFormModel product = new AddProductsFormModel()
            {
                Name = "Name",
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Price = 100,
            };
           
            var productService = new ProductService(data);

            var result =  productService.AddProductsAsync(product);

            Assert.NotNull(result);
            Assert.False(result.IsFaulted);
        }

        [Fact]

        public void AddProductAsyncShouldReturnNoView()
        {


            using var data = DatabaseMock.Instance;
            AddProductsFormModel product = new AddProductsFormModel()
            {
             
            };

            var productService = new ProductService(data);

            var result = productService.AddProductsAsync(product);

            Assert.True(result.IsFaulted);

        }
        [Fact]

        public async void DeleteProductAsyncShouldReturnCorrectId()
        {


            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Products.AddAsync(new Product
            {
                Id = appId,
                Name = "Name",
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Price = 100,
            });
            await data.SaveChangesAsync();
            var producService = new ProductService(data);


            var a = data.Products.FirstOrDefault(x => x.Id == appId);

            Assert.NotNull(a);


            var result = producService.DeleteProductAsync(appId);

            var b = data.Products.FirstOrDefault(x => x.Id == appId);

            Assert.Null(b);


        }

        [Fact]

        public async void DeleteProductAsyncShouldReturnException()
        {


            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Products.AddAsync(new Product
            {
                Id = 2,
                Name = "Name",
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Price = 100,
            });
            await data.SaveChangesAsync();
            var producService = new ProductService(data);

            var result = producService.DeleteProductAsync(appId);

            await Assert.ThrowsAsync<NullReferenceException>(() => result);

        }

      
    }
}
