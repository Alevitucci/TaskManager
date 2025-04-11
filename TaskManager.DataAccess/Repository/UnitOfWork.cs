using TaskManager.DataAccess.Data;

namespace TaskManager.DataAccess.Repository.IRepository;

public class UnitOfWork : IUnitOfWork

{
    public ApplicationDbContext _db;
   
    public IApplicationUserRepository ApplicationUser { get; private set; }
    public ITaskRepository Task { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        ApplicationUser = new ApplicationUserRepository(_db);
        Task = new TaskRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}