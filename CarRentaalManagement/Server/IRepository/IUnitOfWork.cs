namespace CarRentaalManagement.Server.IRepository;
public interface IUnitOfWork: IDisposable
{
    Task Save(HttpContext httpContext);


    // IGenericRepository<T> GetRepository<T>() where T : class;
    IGenericRepository<Make> MakeRepository { get; }
    IGenericRepository<Booking> BookingRepository { get; }
    IGenericRepository<Colour> ColourRepository { get; }
    IGenericRepository<Customer> CustomerRepository { get; }
    IGenericRepository<Model> ModelRepository { get; }
    IGenericRepository<Vehicle> VehicleRepository { get; }

    bool BeginNewTransaction();
    bool RollBackTransaction();

}
