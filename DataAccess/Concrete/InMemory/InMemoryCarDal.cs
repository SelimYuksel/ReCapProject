using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car { Id = 1, BrandId = 1, ColorId="Mavi", ModelYear = "2017", DailyPrice = 220000, Description = "Audi A3" },
                new Car { Id = 2, BrandId = 1, ColorId="Gri", ModelYear = "2016", DailyPrice = 450000, Description = "Mercedes C Serisi" },
                new Car { Id = 3, BrandId = 2, ColorId="Krom Gri", ModelYear = "2015", DailyPrice = 280000, Description = "Ford Focus" },
                new Car { Id = 4, BrandId = 3, ColorId="Kırmızı", ModelYear = "2020", DailyPrice = 150000, Description = "Opel Astra" },
                new Car { Id = 5, BrandId = 3, ColorId="Beyaz", ModelYear = "2019", DailyPrice = 380000, Description = "Opel Insignia"}
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

        public List<Car> GetAll()
        {
            return _cars;
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
    }
}
