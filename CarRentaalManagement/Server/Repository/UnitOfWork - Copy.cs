//using CarRentaalManagement.Server.Data;
//using CarRentaalManagement.Server.IRepository;
//using Microsoft.EntityFrameworkCore;

//namespace CarRentaalManagement.Server.Repository;

//public class UnitOfWork : IUnitOfWork
//{
//    private readonly ApplicationDbContext _context;

//#warning
//    private IGenericRepository<Make> _makeRepository;
//    public UnitOfWork(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public IGenericRepository<Make> MakeRepository => _makeRepository ?? 
//        new GenericRepository<Make>(_context);

//    public void Dispose()
//    {
//        _context.Dispose();
//        GC.SuppressFinalize(this);
//    }

//    //username vb gibi verileri erismek icin httpcontext
//    public async Task Save(HttpContext httpContext)
//    {
//        var user = httpContext.User.Identity.Name;
         
        
//            var entries = _context.ChangeTracker.Entries()
//            .Where(q => q.State == EntityState.Modified ||
//                        q.State == EntityState.Added);

//        foreach (var entry in entries)
//        {
//            ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
//            ((BaseDomainModel)entry.Entity).UpdatedBy = user;


//            if(entry.State == EntityState.Added)
//            {
//                ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
//                ((BaseDomainModel)entry.Entity).CreatedBy = user;
//            }
//        }
//        await _context.SaveChangesAsync();
//    }
//}
