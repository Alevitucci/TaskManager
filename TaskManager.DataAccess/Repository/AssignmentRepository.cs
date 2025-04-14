using TaskManager.DataAccess.Data;
using TaskManager.DataAccess.Repository.IRepository;
using TaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccess.Repository;

namespace TaskManager.DataAccess.Repository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        private ApplicationDbContext _db;
        public AssignmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Assignment assignment)
        {
            _db.Assignments.Update(assignment);
        }
    }
}
