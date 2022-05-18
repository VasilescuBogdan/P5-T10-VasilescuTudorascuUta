namespace CarRentingAsp.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        
        IAnswerRepository AnswerRepository { get; }
        IBookingRepository BookingRepository { get; }
        ICar_CategoryRepository Car_CategoryRepository { get; }
        ICarRepository CarRepository { get; }
        IContactRepository ContactRepository { get; }

        IUserRepository UserRepository { get; }
        IRespondRepository RespondRepository { get; }
        IReviewRepository ReviewRepository { get; }
       
        void Save();
    }
}
