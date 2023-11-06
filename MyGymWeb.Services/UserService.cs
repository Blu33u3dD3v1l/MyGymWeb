using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MyGymWeb.Services
{

    public class UserService : IUserService
    {

        private readonly MyGymProjectDbContext data;

        public UserService(MyGymProjectDbContext data)
        {
            this.data = data;

        }

        public async Task AddAppointmentAsync(Guid id, string userId, AppointmentFormModel model)
        {
            var currentUser = await data.Appointments.FirstOrDefaultAsync(a => a.UserId == userId);


            if (data.Trainers.Any(x => x.Name == model.TrainerName))
            {
                var appointment = new Appointment()
                {
                    Id = model.Id,
                    AppointmentTime = model.AppointmentTime,
                    ClientFullName = model.ClientFullName,
                    Email = model.Email,
                    TrainerName = model.TrainerName,
                    UserId = userId,
                    TrainerId = id,
                };

                if (appointment.AppointmentTime < DateTime.Now)
                {
                    throw new InvalidDataException();
                }
                await data.Appointments.AddAsync(appointment);
                await data.SaveChangesAsync();
            }
            else
            {

                throw new InvalidOperationException();

            }

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
            if (appointment == true)
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


            if (!currentUser!.UsersProducts.Any(m => m.ProductId == id))
            {
                currentUser.UsersProducts.Add(new UserProduct()
                {
                    ProductId = productForBuy!.Id,
                    UserId = currentUser.Id,
                    Product = productForBuy,
                    User = currentUser,
                    TotalCost = productForBuy.Price
                });

                productForBuy.ProductCount = 1;
                //currentUser.Amount -= productForBuy.Price;
            }
            else
            {
                var a = currentUser.UsersProducts.FirstOrDefault(x => x.ProductId == id);
                a!.TotalCost += productForBuy!.Price;

                productForBuy.ProductCount++;
                //currentUser.Amount -= productForBuy.Price;
            }

            await data.SaveChangesAsync();



        }

        public async Task BuyProducts(int productId, string userId)
        {
            var currentUser = await data.Users
                .Where(u => u.Id == userId)
                .Include(x => x.UsersProducts)
                .FirstOrDefaultAsync();


            decimal count = 0;

            if (!currentUser!.UsersProducts.Any())
            {
                throw new NullReferenceException();
            }

            foreach (var item in currentUser!.UsersProducts)
            {

                count += item.TotalCost;

            }

            if (count < 100)
            {
                count += 20;
            }

            if (currentUser.Amount - count < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                currentUser.Amount -= count;
                foreach (var item in currentUser.UsersProducts)
                {
                    data.RemoveRange(item);
                }
            }

            await data.SaveChangesAsync();

        }

        public async Task CancelUserApplicationAsync(int id)
        {

            var currentAppointmentToCancel = await data.Appointments.FirstOrDefaultAsync(x => x.Id == id);

            if (currentAppointmentToCancel == null)
            {
                throw new Exception("Appointment is null");
            }

            data.Appointments.RemoveRange(currentAppointmentToCancel);
            await data.SaveChangesAsync();

        }

        public async Task Code(string userId, string code)
        {

            var a = data.UsersProducts.FirstOrDefault(x => x.UserId == userId);

            if (code == "AAA-12345")
            {
                a!.PromoCode = code;

            }


            await data.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<TrainerViewModel>> GetAllMyTrainersAsync(string userId)
        {
            var user = await data.Users
               .Where(u => u.Id == userId)
               .Include(u => u.UsersTrainers)
               .ThenInclude(x => x.Trainer)
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user.UsersTrainers
                .Select(m => new TrainerViewModel()
                {
                    Id = m.Trainer.Id,
                    Name = m.Trainer.Name,
                    ImageUrl = m.Trainer.ImageUrl,
                    Info = m.Trainer.Info,
                    Motto = m.Trainer.Motto,
                    PhoneNumber = m.Trainer.PhoneNumber,
                    Practis = m.Trainer.Practis,
                    PricePerHour = m.Trainer.PricePerHour,
                    UserId = userId
                });
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

        public async Task<IEnumerable<UserTrainersFormModel>> GetMyTrainersAsync(string userId)
        {
            var currenUser = await data.Users.FirstOrDefaultAsync();

            List<UserTrainersFormModel> result = new List<UserTrainersFormModel>();


            foreach (var item in data.Appointments.Where(x => x.UserId == userId))
            {
                var a = new UserTrainersFormModel()
                {
                    Id = item.Id,
                    AppointmentTime = item.AppointmentTime.ToString(),
                    ClientFullName = item.ClientFullName,
                    Email = item.Email,
                    TrainerName = item.TrainerName,
                    TrainerId = item.TrainerId,
                };

                result.Add(a);
            }

            return result;
        }

        public async Task ReturnProductAsync(string userId, int id)
        {
            var product = await data.Products
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var user = await data.Users
                .Where(x => x.Id == userId)
                .Include(x => x.UsersProducts)
                .FirstOrDefaultAsync();

            if (product == null || user == null)
            {
                throw new ArgumentException("Product or User not found!");

            }

            var a = user.UsersProducts.FirstOrDefault(x => x.ProductId == id);

            if (a?.Product.ProductCount > 1)
            {

                a!.TotalCost = a.TotalCost - product.Price;
                product.ProductCount--;

            }
            else
            {
                a!.TotalCost = a.TotalCost - product.Price;
                data.RemoveRange(a);
            }

            await data.SaveChangesAsync();
        }

        public async Task<string> UserFullName(string userId)
        {
            var user = await data.Users
                 .FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null)
            {
                throw new NullReferenceException();
            }

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}
