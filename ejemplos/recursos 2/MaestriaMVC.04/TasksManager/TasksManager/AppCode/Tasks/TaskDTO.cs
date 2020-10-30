﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksManager
{
    public class TaskDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}