﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length<3)
            {
                Console.WriteLine("Araç ismi 2 karekterden fazla olmalıdır");
            }
            else if(car.DailyPrice<=0)
            {
                Console.WriteLine("Araç günlük bedeli 0 dan yüksek olmalıdır");
            }
            else
            {
                _carDal.Add(car);
            }
            
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetail();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId== ColorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
