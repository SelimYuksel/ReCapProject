using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId=100, ModelYear = "2017", DailyPrice = 220000, Description = "Audi A3" },
                new Car { Id = 2, BrandId = 1, ColorId=101, ModelYear = "2016", DailyPrice = 450000, Description = "Mercedes C Serisi" },
                new Car { Id = 3, BrandId = 2, ColorId=103, ModelYear = "2015", DailyPrice = 280000, Description = "Ford Focus" },
                new Car { Id = 4, BrandId = 3, ColorId=100, ModelYear = "2020", DailyPrice = 150000, Description = "Opel Astra" },
                new Car { Id = 5, BrandId = 3, ColorId=104, ModelYear = "2019", DailyPrice = 380000, Description = "Opel Insignia"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }
    }
}
