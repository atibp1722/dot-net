using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Actions
    {
        public static event EventHandler<Data> TestEvent;

        public static void sample_event(int age, string name)
        {
            Data dt = new Data();
            dt.name = name;
            dt.age = age;

            TestEvent?.Invoke(null, dt);
        }
    }
}
