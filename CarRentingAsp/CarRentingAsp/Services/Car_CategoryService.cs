using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class Car_CategoryService : BaseService
    {
        public Car_CategoryService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Car_Category> GetCar_Category()
        {
            return repositoryWrapper.Car_CategoryRepository.FindAll().ToList();
        }

        public List<Car_Category> GetCar_CategoryByCondition(Expression<Func<Car_Category, bool>> expression)
        {
            return repositoryWrapper.Car_CategoryRepository.FindByCondition(expression).ToList();
        }

        public void AddCar_Category(Car_Category car_category)
        {
            repositoryWrapper.Car_CategoryRepository.Create(car_category);
        }

        public void UpdateCar_Category(Car_Category car_category)
        {
            repositoryWrapper.Car_CategoryRepository.Update(car_category);
        }

        public void DeleteCar_Category(Car_Category car_category)
        {
            repositoryWrapper.Car_CategoryRepository.Delete(car_category);
        }
    }
}