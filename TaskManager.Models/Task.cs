using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DataType Scheduler { get; set; }
    }
}
