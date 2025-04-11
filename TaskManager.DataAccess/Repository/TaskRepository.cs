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
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        private ApplicationDbContext _db;
        public TaskRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Task task)
        {
            _db.Tasks.Update(task);
        }
    }
}
