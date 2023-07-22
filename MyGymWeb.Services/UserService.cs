using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;
using System.Collections.Immutable;


namespace MyGymWeb.Services
{
    public class UserService : IUserService
    {

        private readonly MyGymProjectDbContext data;


        public UserService(MyGymProjectDbContext data)
        {
            this.data = data;

        }

        public async Task AddAppointmentAsync(string userId, AppointmentFormModel model)
        {
            var currentUser = await data.Appointments.FirstOrDefaultAsync(a => a.UserId == userId);
            

         
            //var a = DateTime.Parse(model.AppointmentTime, CultureInfo.InvariantCulture);
            //var b = $"{a.Day}/{a.Month}/{a.Year}";
            //var c = $"{a.Hour}:{a.Minute}";

            var appointment = new Appointment()
            {
                AppointmentTime = model.AppointmentTime,
                ClientFullName = model.ClientFullName,            
                Email = model.Email,
                TrainerName = model.TrainerName,
                UserId = userId,
                
            };




            await data.Appointments.AddAsync(appointment);
            await data.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {

            List<UserServiceModel> result;

            result = data.Trainers.Select(x => new UserServiceModel()
            {
                UserId = x.UserId,
                Email = x!.User!.Email,
                FullName = $"{x.User.FirstName} {x.User.LastName}",
                PhoneNumber = x.PhoneNumber,


            }).ToList();

            var trainerIds = result.Select(x => x.UserId).ToArray();
            result.AddRange(await data.Users
                .Where(u => trainerIds.Contains(u.Id) == false)
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}",

                })
                .ToListAsync());

            return result;
        }

        public async Task<bool> AppointmentExistByUserId(string userId, Guid id)
        {
            var trainer = await data.UsersTrainers.FirstOrDefaultAsync(x => x.TrainerId == id);
            bool appointment = await data.UsersTrainers.AnyAsync(a => a.UserId == userId && a.TrainerId == id);
            if(appointment == true)
            {
                throw new Exception();
            }
            return appointment;
        }

        public async Task BuyProductAsync(int id, string userId)
        {
            var currentUser = await data.Users
                .Where(u => u.Id == userId)
                .Include(x => x.UsersProducts)
                .FirstOrDefaultAsync();

            var productForBuy = await data.Products
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();



            if ((currentUser!.Amount - productForBuy!.Price) < 0)
            {
                throw new Exception("Amount is not enough!");
            }

            if (!currentUser.UsersProducts.Any(m => m.ProductId == id))
            {
                currentUser.UsersProducts.Add(new UserProduct()
                {
                    ProductId = productForBuy.Id,
                    UserId = currentUser.Id,
                    Product = productForBuy,
                    User = currentUser


                });
                productForBuy.ProductCount += 1;
                currentUser.Amount -= productForBuy.Price;
            }
            else
            {
                productForBuy.ProductCount += 1;
                currentUser.Amount -= productForBuy.Price;
            }
          
            await data.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsForBuyAsync(string userId)
        {
            var user = await data.Users
               .Where(u => u.Id == userId)
               .Include(u => u.UsersProducts)
                .ThenInclude(x => x.Product)
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user.UsersProducts
                .Select(m => new ProductViewModel()
                {
                    Description = m.Product.Description,
                    Mark = m.Product.Mark,
                    Id = m.ProductId,
                    ImageUrl = m.Product.ImageUrl,
                    Name = m.Product.Name,
                    Price = m.Product.Price,
                    ProductCount = m.Product.ProductCount,
                });
        }

        public async Task ReturnProductAsync(string userId, int id)
        {
            var product = await data.Products
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var user = await data.Users
                .Where(x => x.Id == userId)
                .FirstOrDefaultAsync();

            if (product == null || user == null)
            {
                throw new ArgumentException("Product or User not found!");

            }

            if (product.ProductCount > 1)
            {
                user.Amount += product.Price;
                product.ProductCount--;

            }
            else
            {
                user.Amount += product.Price;
                product.ProductCount--;

                var productForReturn = await data.UsersProducts
                .Where(x => x.ProductId == id && x.UserId == userId)
                .FirstOrDefaultAsync();

                if (productForReturn == null)
                {
                    throw new ArgumentException("Product or User not found!");
                }
                data.RemoveRange(productForReturn);
               
            }

            await data.SaveChangesAsync();
        }

        public async Task TrainerUserRelationAsync(string userId, Guid id)
        {
            var currentUser = await data.Users
               .Where(u => u.Id == userId)
               .Include(x => x.UsersTrainers)
               .FirstOrDefaultAsync();

            var currentTrainer = await data.Trainers
              .Where(u => u.Id == id)             
              .FirstOrDefaultAsync();

            if (!currentUser!.UsersTrainers.Any(m => m.TrainerId == id && m.UserId == userId))
            {
                currentUser.UsersTrainers.Add(new UserTrainer()
                {
                    TrainerId = currentTrainer!.Id,
                    UserId = currentUser.Id,
                    Trainer = currentTrainer,
                    User = currentUser


                });
             
            }
            else
            {
                throw new InvalidOperationException("Wrong user");
            }
            
            await data.SaveChangesAsync();
        }

        //public async Task DeleteUserAsync(string id)
        //{

        //   var user = await data.Users.FirstOrDefaultAsync(x => x.Id == id);


        //    if(user != null)
        //    {
        //        if (user.Email == "Admin@Admin.bg")
        //        {
        //            throw new SystemException();
        //        }

        //        data.Users.RemoveRange(user);
        //        await data.SaveChangesAsync();
        //    }



        //}

        public async Task<string> UserFullName(string userId)
        {
            var user = await data.Users
                 .FirstOrDefaultAsync(x => x.Id == userId);

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}
