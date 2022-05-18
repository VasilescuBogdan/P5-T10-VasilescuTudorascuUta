using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class CarService : BaseService
    {
        public CarService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Car> GetCar()
        {
            return repositoryWrapper.CarRepository.FindAll().ToList();
        }

        public List<Car> GetCarByCondition(Expression<Func<Car, bool>> expression)
        {
            return repositoryWrapper.CarRepository.FindByCondition(expression).ToList();
        }

        public void AddCar(Car car)
        {
            repositoryWrapper.CarRepository.Create(car);
        }

        public void UpdateCar(Car car)
        {
            repositoryWrapper.CarRepository.Update(car);
        }

        public void DeleteCar(Car car)
        {
            repositoryWrapper.CarRepository.Delete(car);
        }
    }
}