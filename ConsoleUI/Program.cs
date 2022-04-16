using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ ARAÇLARIMIZ -------------");
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç Markası "+car.BrandName+" "+car.Description+ "\nAraç Modeli "+car.ModelYear
                    +"\nAraç Rengi "+car.ColorName+"\nAraç Günlük Bedeli "+car.DailyPrice);
                Console.WriteLine("------------    -------------");
            }
        }
    }
}
