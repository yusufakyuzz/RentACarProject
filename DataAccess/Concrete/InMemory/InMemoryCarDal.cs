using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Car> 
            {
                new Car{Id=1,BrandId=2,CarName="Renault",ColorId=3,DailyPrice=450,ModelYear="2019",Description="Renault Megane"},
                new Car{Id=2,BrandId=3,CarName="Opel",ColorId=3,DailyPrice=560,ModelYear="1996",Description="Opel Corsa"},
                new Car{Id=3,BrandId=4,CarName="Toyata",ColorId=3,DailyPrice=380,ModelYear="2022",Description="Toyata Coralla"}

            };
        }

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(c=>c.Id==car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carList.ToList();
        }

        public Car GetById(int id)
        {
           return _carList.SingleOrDefault(c=>c.Id==id);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdated = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdated.CarName = car.CarName;
            carToUpdated.BrandId = car.BrandId;
            carToUpdated.ColorId = car.ColorId;
            carToUpdated.DailyPrice=car.DailyPrice;
            carToUpdated.Description=car.Description;
            

        }
    }
}
