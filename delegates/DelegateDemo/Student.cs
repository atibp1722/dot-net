using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void study_progress(int hours, string subject);
    public delegate void study_completed(string subject);

    class Student
    {
        public void study(int hours, string subject, study_progress del_stdprg, study_completed del_stdcmpl)
        {
            for (int i = 0; i < hours; i++)
            {
                Thread.Sleep(1000);
                del_stdprg(i+1,subject);
            }
            del_stdcmpl(subject);
        }
    }
}
