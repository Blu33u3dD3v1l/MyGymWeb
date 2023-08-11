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
            AddProductValidationModel product = new AddProductValidationModel()
            {
                Name = "Name",
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Price = 100,
            };

            var productService = new ProductService(data);

            var result = productService.AddProductsAsync(product);

            Assert.NotNull(result);
            Assert.False(result.IsFaulted);
        }

        [Fact]

        public void AddProductAsyncShouldReturnNoView()
        {


            using var data = DatabaseMock.Instance;
            AddProductValidationModel product = new AddProductValidationModel()
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
        [Fact]

        public async void EditProductByIdAsyncShouldReturnCorrectId()
        {
            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Products.AddAsync(new Product
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Price = 100,
            });


            await data.SaveChangesAsync();
            var producService = new ProductService(data);

            var a = data.Products.FirstOrDefault(x => x.Id == appId);
            if (a != null)
            {
                TestViewModel model = new TestViewModel
                {
                    Id = a.Id,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Mark = a.Mark,
                    Name = a.Name,
                    Price = a.Price,

                };

                var result = producService.EditByIdAsync(appId, model);

                Assert.NotNull(result);

            }



        }

        [Fact]

        public async void EditProductByIdAsyncShouldReturnIncorrectId()
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

            var a = data.Products.FirstOrDefault(x => x.Id == appId);

            TestViewModel model = new TestViewModel
            {
                Id = 3,
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Name = "Name",
                Price = 100,

            };


            var result = producService.EditByIdAsync(appId, model);
            Assert.True(result.IsFaulted);

        }

        [Fact]
        public async void GetAllProductsAsyncShouldReturnsSingleView()
        {


            using var data = DatabaseMock.Instance;
            await data.Products.AddAsync(new Product
            {
                Id = 1,
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Name = "Name",
                Price = 100,

            });


            await data.SaveChangesAsync();

            var productService = new ProductService(data);

            var result = await productService.GetAllProductsAsync();

            Assert.Single(result);


        }

        [Fact]
        public async void GetAllAsyncShouldNotReturnViews()
        {


            using var data = DatabaseMock.Instance;

            await data.SaveChangesAsync();



            var productService = new ProductService(data);

            var result = await productService.GetAllProductsAsync();

            var count = result.Count();

            Assert.True(count == 0);


        }

        [Fact]
        public async void GetAllAsyncShouldReturnMoreThanOneView()
        {


            using var data = DatabaseMock.Instance;
            await data.Products.AddAsync(new Product
            {
                Id = 1,
                Description = "Description",
                ImageUrl = "ImageUrl",
                Mark = "Mark",
                Name = "Name",
                Price = 100,

            });
            await data.Products.AddAsync(new Product
            {
                Id = 2,
                Description = "Description1",
                ImageUrl = "ImageUrl1",
                Mark = "Mark1",
                Name = "Name1",
                Price = 101,

            });


            await data.SaveChangesAsync();
            var productService = new ProductService(data);

            var result = await productService.GetAllProductsAsync();

            var count = result.Count();

            Assert.True(count > 1);


        }

        [Fact]
        public async void GetEditProductAsyncShouldReturnCorrectValue()
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

            var result = await producService.GetEditProductAsync(appId);

            Assert.NotNull(result);


          
        }

        [Fact]
        public async void GetEditProductAsyncShouldReturnException()
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

            var result =  producService.GetEditProductAsync(appId);

            await Assert.ThrowsAsync<NullReferenceException>(() => result);
        }

        [Fact]
        public async void GetProductDescriptionShouldReturnCorrectValue()
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

            var result = await producService.GetProductDescriptionAsync(appId);

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetProductDescriptionShouldReturnException()
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

            var result = producService.GetProductDescriptionAsync(appId);

            await Assert.ThrowsAsync<ArgumentNullException>(() => result);
        }
    }
}

