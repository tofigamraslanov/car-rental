using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFrameworkCore;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Managers
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //UpdateUser(userManager);

            //AddUser(userManager);

            //GetAllUsers(userManager);

            //GetAllCustomers(customerManager);

            GetRentalDetails(rentalManager);

            //AddRental(rentalManager);

            //GetAllColors(colorManager);

            //AddColor(colorManager);

            //AddBrand(brandManager);

            //UpdateBrand(brandManager);

            //GetAllCars(carManager, brandManager, colorManager);

            //GetAllCarsByDailyPrice(carManager, brandManager, colorManager);

            //GetAllCarsByModelYear(carManager, brandManager, colorManager);

            //AddCar(carManager, brandManager, colorManager);

            //UpdateCar(carManager, brandManager, colorManager);

            //CarDetails(carManager);

            #region InMemoryCarDal

            /*
            Console.WriteLine("--- GetAll method ---");
            List<Car> cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine($"Car name: {car.Description}, daily price: {car.DailyPrice}, model year:{car.ModelYear}");
            }
            Console.WriteLine();

            Console.WriteLine("--- GetById method ---");
            Car carId = carManager.GetById(1);
            Console.WriteLine(carId.Description);
            Console.WriteLine();

            Console.WriteLine("--- Add method ---");
            carManager.Add(new Car() { Id = 6, BrandId = 2, ColorId = 5, ModelYear = 2015, DailyPrice = 5700, Description = "Ferrari" });
            foreach (var car in cars)
            {
                Console.WriteLine($"Car name: {car.Description}, daily price: {car.DailyPrice}, model year:{car.ModelYear}");
            }
            Console.WriteLine();

            Console.WriteLine("--- Update method ---");
            carManager.Update(new Car() { Id = 4, BrandId = 2, ColorId = 5, ModelYear = 2005, DailyPrice = 3500, Description = "Lamborghini" });
            foreach (var car in cars)
            {
                Console.WriteLine($"Car name: {car.Description}, daily price: {car.DailyPrice}, model year:{car.ModelYear}");
            }
            Console.WriteLine();

            Console.WriteLine("--- Delete method ---");
            carManager.Delete(new Car() { Id = 5, BrandId = 1, ColorId = 5, ModelYear = 2010, DailyPrice = 8700, Description = "Ford" });
            foreach (var car in cars)
            {
                Console.WriteLine($"Car name: {car.Description}, daily price: {car.DailyPrice}, model year:{car.ModelYear}");
            }
            */

            #endregion

            Console.ReadLine();
        }

        //private static void UpdateUser(UserManager userManager)
        //{
        //    var result = userManager.Update(new User { Id = 5, FirstName = "Ahsan", LastName = "Maharramov", Email = "ahsan.maharramov@mail.ru", Password = "ahsan12" });
        //    Console.WriteLine(result.Message);
        //}

        //private static void AddUser(UserManager userManager)
        //{
        //    var result = userManager.Add(new User() { FirstName = "Ahsan", LastName = "Maharramov", Email = "ahsanmaharramov@mail.ru", Password = "167182" });
        //    Console.WriteLine(result.Message);
        //}

        private static void GetAllUsers(UserManager userManager)
        {
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName + " / " + user.LastName + " / " + user.Email);
            }
        }

        private static void GetAllCustomers(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void GetRentalDetails(RentalManager rentalManager)
        {
            var result = rentalManager.GetRentalDetails(r => r.Id == 1);
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.UserName + " / " + rental.CustomerName + " / " + rental.CarName);
            }
        }

        private static void AddRental(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental()
            { CarId = 5, CustomerId = 3, RentDate = new DateTime(2020, 10, 24), ReturnDate = new DateTime(2021, 2, 11) });
            Console.WriteLine(result.Message);
        }

        private static void UpdateBrand(BrandManager brandManager)
        {
            Console.WriteLine("Update brand");
            brandManager.Update(new Brand() { BrandId = 5, BrandName = "Kia" });
        }

        private static void CarDetails(CarManager carManager)
        {
            var carDetails = carManager.GetCarDetails();
            foreach (var carDetail in carDetails.Data)
            {
                Console.WriteLine(carDetail.BrandName + " / " + carDetail.ColorName + " / " + carDetail.CarName + " / " +
                                  carDetail.DailyPrice);
            }
        }

        private static void UpdateCar(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Update car");
            carManager.Update(new Car()
            { Id = 1, BrandId = 6, ColorId = 7, DailyPrice = 1700, ModelYear = 2012, Description = "A super car" });
            var updatedCar = carManager.GetById(1);
            Console.WriteLine(
                $"{updatedCar.Data.Id} {brandManager.GetById(updatedCar.Data.BrandId).Data.BrandName} {colorManager.GetById(updatedCar.Data.ColorId).Data.ColorName} {updatedCar.Data.ModelYear} {updatedCar.Data.DailyPrice} {updatedCar.Data.Description}");
        }

        private static void AddCar(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Add car");
            carManager.Add(new Car() { BrandId = 8, ColorId = 6, ModelYear = 2016, DailyPrice = 1650, Description = "A car" });
            var cars2 = carManager.GetAll();
            foreach (Car car in cars2.Data)
            {
                Console.WriteLine(
                    $"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.ModelYear} {car.DailyPrice} {car.Description}");
            }

            Console.WriteLine();
        }

        private static void GetAllCarsByModelYear(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("---- Get all cars by model year ----");
            var carsByModelYear = carManager.GetByModelYear(2015);
            foreach (Car car in carsByModelYear.Data)
            {
                Console.WriteLine(
                    $"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.DailyPrice}");
            }

            Console.WriteLine();
        }

        private static void GetAllCarsByDailyPrice(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("---- Get all cars by daily price between 1500 and 2000 ----");
            var carsByDailyPrice = carManager.GetByDailyPrice(1500, 2000);
            foreach (Car car in carsByDailyPrice.Data)
            {
                Console.WriteLine(
                    $"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.DailyPrice}");
            }

            Console.WriteLine();
        }

        private static void GetAllCars(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("---- Get all cars ----");
            var cars = carManager.GetAll();
            foreach (Car car in cars.Data)
            {
                Console.WriteLine(
                    $"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.ModelYear} {car.DailyPrice} {car.Description}");
            }

            Console.WriteLine();
        }

        private static void AddBrand(BrandManager brandManager)
        {
            Console.WriteLine("Add brand");
            brandManager.Add(new Brand() { BrandName = "Toyota" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine();
        }

        private static void AddColor(ColorManager colorManager)
        {
            Console.WriteLine("Pink color added to colors");
            colorManager.Add(new Color() { ColorName = "Pink" });
            var colors2 = colorManager.GetAll();
            foreach (var color in colors2.Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetAllColors(ColorManager colorManager)
        {
            Console.WriteLine("---- Get all colors ----");
            var colors = colorManager.GetAll();
            foreach (var color in colors.Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine();
        }
    }
}
