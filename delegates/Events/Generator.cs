using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Generator
    {
        public void generate_info(object sender, Data e)
        {
            Console.WriteLine("Info generated for {0} having age {1}",e.name,e.age);
        }
    }
}
