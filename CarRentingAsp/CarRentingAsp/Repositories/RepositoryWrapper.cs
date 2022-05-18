using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private CarRentingContext _carRentingcontext;
       
        private IAnswerRepository? _answerRepository;
        private IBookingRepository? _bookingRepository;
        private ICar_CategoryRepository? _car_CategoryRepository;
        private ICarRepository? _carRepository;
        private IContactRepository? _contactRepository;
        private IRespondRepository? _respondRepository;
        private IReviewRepository? _reviewRepository;
        private IUserRepository _userRepository;




        public IAnswerRepository AnswerRepository
        {
            get
            {
                if (_answerRepository == null)
                {
                    _answerRepository = new AnswerRepository(_carRentingcontext);
                }

                return _answerRepository;
            }
        }

       

        public IBookingRepository BookingRepository
        {
            get
            {
                if (_bookingRepository == null)
                {
                    _bookingRepository = new BookingRepository(_carRentingcontext);
                }

                return _bookingRepository;
            }
        }

        public ICar_CategoryRepository Car_CategoryRepository
        {
            get
            {
                if (_car_CategoryRepository == null)
                {
                    _car_CategoryRepository = new Car_CategoryRepository(_carRentingcontext);
                }

                return _car_CategoryRepository;
            }
        }

        public ICarRepository CarRepository
        {
            get
            {
                if (_carRepository == null)
                {
                    _carRepository = new CarRepository(_carRentingcontext);
                }

                return _carRepository;
            }
        }

        public IContactRepository ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                {
                    _contactRepository = new ContactRepository(_carRentingcontext);
                }

                return _contactRepository;
            }
        }

       
        

        public IRespondRepository RespondRepository
        {
            get
            {
                if (_respondRepository == null)
                {
                    _respondRepository = new RespondRepository(_carRentingcontext);
                }

                return _respondRepository;
            }
        }

        public IReviewRepository ReviewRepository
        {
            get
            {
                if (_reviewRepository == null)
                {
                    _reviewRepository = new ReviewRepository(_carRentingcontext);
                }

                return _reviewRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_carRentingcontext);
                }
                return _userRepository;
            }
        }



        public RepositoryWrapper(CarRentingContext carRentingContext)
        {
            _carRentingcontext = carRentingContext;
        }

        public void Save()
        {
            _carRentingcontext.SaveChanges();
        }

    }
}
