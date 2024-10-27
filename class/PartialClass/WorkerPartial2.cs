using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class WorkerPartial
    {
        public string get_details()
        {
            return fname + " " + lname + " is a " + designation;
        }
    }
}
