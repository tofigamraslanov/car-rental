using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("---- Get all colors ----");
            var colors = colorManager.GetAll();
            foreach (var color in colors.Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine();

            //Console.WriteLine("Pink color added to colors");
            //colorManager.Add(new Color() { ColorName = "Pink" });
            //List<Color> colors2 = colorManager.GetAll();
            //foreach (var color in colors2)
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //Console.WriteLine("Add brand");
            //brandManager.Add(new Brand() { BrandName = "Toyota" });
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Update brand");
            //brandManager.Update(new Brand() { BrandId = 5, BrandName = "Kia" });

            Console.WriteLine("---- Get all cars ----");
            var cars = carManager.GetAll();
            foreach (Car car in cars.Data)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.ModelYear} {car.DailyPrice} {car.Description}");
            }
            Console.WriteLine();

            Console.WriteLine("---- Get all cars by daily price between 1500 and 2000 ----");
            var carsByDailyPrice = carManager.GetByDailyPrice(1500, 2000);
            foreach (Car car in carsByDailyPrice.Data)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.DailyPrice}");
            }
            Console.WriteLine();

            Console.WriteLine("---- Get all cars by model year ----");
            var carsByModelYear = carManager.GetByModelYear("2015");
            foreach (Car car in carsByModelYear.Data)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).Data.BrandName} {colorManager.GetById(car.ColorId).Data.ColorName} {car.DailyPrice}");
            }
            Console.WriteLine();

            //Console.WriteLine("Add car");
            //carManager.Add(new Car() { BrandId = 8, ColorId = 6, ModelYear = "2016", DailyPrice = 1650, Description = "A car" });
            //List<Car> cars2 = carManager.GetAll();
            //foreach (Car car in cars2)
            //{
            //    Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).BrandName} {colorManager.GetById(car.ColorId).ColorName} {car.ModelYear} {car.DailyPrice} {car.Description}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Update car");
            //carManager.Update(new Car() { Id = 1, BrandId = 6, ColorId = 7, DailyPrice = 1700, ModelYear = "2012", Description = "A super car" });
            //Car updatedCar = carManager.GetById(1);
            //Console.WriteLine($"{updatedCar.Id} {brandManager.GetById(updatedCar.BrandId).BrandName} {colorManager.GetById(updatedCar.ColorId).ColorName} {updatedCar.ModelYear} {updatedCar.DailyPrice} {updatedCar.Description}");

            var carDetails = carManager.GetCarDetails();
            foreach (var carDetail in carDetails.Data)
            {
                Console.WriteLine(carDetail.BrandName + " / " + carDetail.ColorName + " / " + carDetail.CarName + " / " + carDetail.DailyPrice);
            }

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
    }
}
