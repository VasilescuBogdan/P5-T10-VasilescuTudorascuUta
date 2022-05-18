using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentingAsp.Repositories
{
    public abstract class RepositoryBase<T>:IRepositoryBase<T> where T : class
    {
        protected CarRentingContext CarRentingContext { get; set; }

        public RepositoryBase(CarRentingContext carRentingContext)
        {
            this.CarRentingContext = carRentingContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.CarRentingContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.CarRentingContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.CarRentingContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.CarRentingContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.CarRentingContext.Set<T>().Remove(entity);
        }
    }
}
