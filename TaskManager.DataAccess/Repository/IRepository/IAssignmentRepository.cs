using TaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskMAnager.DataAccess.Repository.IRepository;

namespace TaskManager.DataAccess.Repository.IRepository
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        public void Update(Assignment assignment);
    }
}
