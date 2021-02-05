using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("---- Get all cars ----");
            List<Car> cars = carManager.GetAll();
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).BrandName} {colorManager.GetById(car.ColorId).ColorName} {car.ModelYear} {car.DailyPrice} {car.Description}");
            }
            Console.WriteLine();

            Console.WriteLine("---- Get all cars by daily price between 1500 and 2000 ----");
            List<Car> carsByDailyPrice = carManager.GetByDailyPrice(1500, 2000);
            foreach (Car car in carsByDailyPrice)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).BrandName} {colorManager.GetById(car.ColorId).ColorName} {car.DailyPrice}");
            }
            Console.WriteLine();

            Console.WriteLine("---- Get all cars by model year ----");
            List<Car> carsByModelYear = carManager.GetByModelYear("2015");
            foreach (Car car in carsByModelYear)
            {
                Console.WriteLine($"{car.Id} {brandManager.GetById(car.BrandId).BrandName} {colorManager.GetById(car.ColorId).ColorName} {car.DailyPrice}");
            }
            Console.WriteLine();

            Console.WriteLine("Update car");
            carManager.Update(new Car() { Id = 1, BrandId = 6, ColorId = 7, DailyPrice = 1700, ModelYear = "2012", Description = "A super car" });
            Car updatedCar = carManager.GetById(1);
            Console.WriteLine($"{updatedCar.Id} {brandManager.GetById(updatedCar.BrandId).BrandName} {colorManager.GetById(updatedCar.ColorId).ColorName} {updatedCar.ModelYear} {updatedCar.DailyPrice} {updatedCar.Description}");

            Console.WriteLine("---- Get all colors ----");
            List<Color> colors = colorManager.GetAll();
            foreach (var color in colors)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine();

            Console.WriteLine("Pink color added to colors");
            //colorManager.Add(new Color() { ColorName = "Pink" });
            //List<Color> colors2 = colorManager.GetAll();
            //foreach (var color in colors2)
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            Console.WriteLine();


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
