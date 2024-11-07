using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class PartialStudent
    {
        static void partial_student_progress(int hours, string subject)
        {
            Console.WriteLine("{0} hours spent studying {1} subject", hours, subject);
        }

        static void partial_student_complete(string subject)
        {
            Console.WriteLine("{0} subject now completed");
        }

        static void partial_student_study()
        {
            study_progress del_stdprg = new study_progress(partial_student_progress);
            study_completed del_stdcmpl = new study_completed(partial_student_complete);

            Student std = new Student();
            std.study(3, "chemistry", del_stdprg, del_stdcmpl);
        }
  
    }
}