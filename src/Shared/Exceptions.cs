﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PerfMonitor
{
    public class Exceptions  // contains type of exception and timestamp
    {
        public String type { get; set; }
        [Key]
        public DateTime timestamp { get; set; }
    }
}