using TaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMAnager.DataAccess.Repository.IRepository;

namespace TaskManager.DataAccess.Repository.IRepository
{
    public interface ITaskRepository : IRepository<Task>
    {
        public void Update(Task task);
    }
}
