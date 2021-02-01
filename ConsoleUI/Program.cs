using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());

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

            Console.ReadLine();
        }
    }
}
