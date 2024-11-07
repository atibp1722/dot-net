using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Db
    {
        public void db_save(object sender, EventArgs e) 
        {
            Console.WriteLine("Inforamtion saved in DB");
        }
    }
}
