using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Mail
    {
        public void send_mail(object sender, Data e)
        {
            Console.WriteLine("Mail sent successfully to {0}",e.name);
        }
    }
}
