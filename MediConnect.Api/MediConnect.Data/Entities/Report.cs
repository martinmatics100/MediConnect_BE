﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Data.Entities
{
    public class Report
    {
        public string ReportID { get; set; }
        public string AdminID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
