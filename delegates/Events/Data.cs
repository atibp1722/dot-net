﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Data: EventArgs
    {
        public int age { get; set; }
        public string name { get; set; }
    }
}
