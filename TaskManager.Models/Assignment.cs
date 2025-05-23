﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Assignment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public string Status { get; set; }
    }
}
