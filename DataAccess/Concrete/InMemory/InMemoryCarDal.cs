using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=13, ModelYear="1993", Description="Good Car"},
                new Car{CarId=2, BrandId=2, ColorId=2, DailyPrice=23, ModelYear="1991", Description="Better Car"},
                new Car{CarId=3, BrandId=3, ColorId=1, DailyPrice=33, ModelYear="2001", Description="Much Better Car"},
                new Car{CarId=4, BrandId=4, ColorId=3, DailyPrice=25, ModelYear="1995", Description="Standart Car"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(p => p.CarId == car.CarId);
            updateToCar.CarId = car.CarId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;

        }

        List<Car> ICarDal.GetById(int id)
        {
            return _car.Where(p => p.CarId == id).ToList();
        }
    }
}
