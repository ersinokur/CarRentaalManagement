using CarRentaalManagement.Server.Data;
using CarRentaalManagement.Server.IRepository;
using CarRentaalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CarRentaalManagement.Server.Repository;

public class UnitOfWork: IUnitOfWork
{
    /// <summary>
    /// GenericRepository ile CRUD işlemlerimizi tek bir yerde topladık.
    /// DB'ye kaydedilmek üzere bekletiyoruz bu işlemi de UOW ile kayıt 
    /// yapıyoruz.
    /// </summary>

    private readonly ApplicationDbContext _context;
    private IDbContextTransaction _transation;

    #region Custom Repositories

    private IGenericRepository<Make> _makeRepository;
    private IGenericRepository<Booking> _bookingRepository;
    private IGenericRepository<Colour> _colourRepository;
    private IGenericRepository<Customer> _customerRepository;
    private IGenericRepository<Model> _modelRepository;
    private IGenericRepository<Vehicle> _vehicleRepository;

    #endregion
    public  UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }


    public IGenericRepository<Make> MakeRepository => _makeRepository ??
                                   new GenericRepository<Make>(_context);
    public IGenericRepository<Model> ModelRepository
            => _modelRepository ??= new GenericRepository<Model>(_context);
    public IGenericRepository<Colour> ColourRepository
        => _colourRepository ??= new GenericRepository<Colour>(_context);
    public IGenericRepository<Vehicle> VehicleRepository
        => _vehicleRepository ??= new GenericRepository<Vehicle>(_context);
    public IGenericRepository<Booking> BookingRepository
        => _bookingRepository ??= new GenericRepository<Booking>(_context);
    public IGenericRepository<Customer> CustomerRepository
        => _customerRepository ??= new GenericRepository<Customer>(_context);

   


    /// <summary>
    /// Yeni bir transaction oluşturmak icin kullanılır.
    /// Peşi sıra işler yapılacaksa; işlemlere başlamadan önce kullanılır
    /// SaveChanges ile işlemler bittiğinde commit edilmiş olur.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool BeginNewTransaction()
    {
        try
        {
            _transation = _context.Database.BeginTransaction();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    /// <summary>
    /// baslatilan transactionda bir hata vara geri al
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool RollBackTransaction()
    {
        try
        {           
           _transation?.Rollback();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

 
         

    //username vb gibi verileri erismek icin httpcontext
    public async Task Save(HttpContext httpContext)
    {
        var user = httpContext.User.Identity.Name;
         
        
            var entries = _context.ChangeTracker.Entries()
            .Where(q => q.State == EntityState.Modified ||
                        q.State == EntityState.Added);

        foreach (var entry in entries)
        {
            ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
            ((BaseDomainModel)entry.Entity).UpdatedBy = user;


            if(entry.State == EntityState.Added)
            {
                ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).CreatedBy = user;
            }
        }

        var transaction = _transation != null ? _transation : _context.Database.BeginTransaction();

        using (transaction)
        {
            try
            {
                //Context boş ise hata fırlatıyoruz
                if (_context == null)
                {
                    throw new ArgumentException("Context is null");
                }

                await _context.SaveChangesAsync();

                //Sorun yok ise kuyruktaki tüm işlemleri commit ederek bitiriyoruz.
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();

                throw new Exception("Error on save changes ", ex);
            }
        }       
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

}
