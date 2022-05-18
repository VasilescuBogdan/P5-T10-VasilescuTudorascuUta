using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class ReviewService : BaseService
    {
        public ReviewService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Review> GetReview()
        {
            return repositoryWrapper.ReviewRepository.FindAll().ToList();
        }

        public List<Review> GetReviewByCondition(Expression<Func<Review, bool>> expression)
        {
            return repositoryWrapper.ReviewRepository.FindByCondition(expression).ToList();
        }

        public void AddReview(Review review)
        {
            repositoryWrapper.ReviewRepository.Create(review);
        }

        public void UpdateReview(Review review)
        {
            repositoryWrapper.ReviewRepository.Update(review);
        }

        public void DeleteReview(Review review)
        {
            repositoryWrapper.ReviewRepository.Delete(review);
        }
    }
}