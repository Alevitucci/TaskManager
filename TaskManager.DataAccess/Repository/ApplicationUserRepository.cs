using TaskManager.DataAccess.Data;
using TaskManager.DataAccess.Repository.IRepository;
using TaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizio.DataAccess.Repository;

namespace TaskManager.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ApplicationUser applicationUser)
        {
            _db.ApplicationUsers.Update(applicationUser);
        }
    }
}
