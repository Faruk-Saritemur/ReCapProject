using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car id : " + car.CarId);
                Console.WriteLine("Price : " + car.DailyPrice);
                Console.WriteLine("Model Year : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine(" ");
            }
        }
    }
}
