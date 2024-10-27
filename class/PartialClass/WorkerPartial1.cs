using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class WorkerPartial
    {
        private string fname;
        private string lname;
        private string designation;

        public string f_name
        {
            set
            {
                fname = value;
            }
            get
            {
                return fname;
            }
        }

        public string l_name
        {
            set
            {
                lname = value;
            }
            get
            {
                return lname;
            }
        }

        public string d_designation
        {
            get => designation; set => designation = value;
        }
    }
}
