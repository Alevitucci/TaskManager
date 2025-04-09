using TaskManager.DataAccess.Data;
using TaskManager.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccess.Repository;

namespace TaskManager.DataAccess.Repository.IRepository;

public class UnitOfWork : IUnitOfWork

{
    private ApplicationDbContext _db;
   
    public IApplicationUserRepository ApplicationUser { get; private set; }
    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        ApplicationUser = new ApplicationUserRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}
