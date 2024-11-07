using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExmpl
{
    public delegate bool scholarship_students(Student scholarship_eligible);
    public class Student
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int year { get; set; }
        public string subject { get; set; }

        public static void scholarship_student(List<Student> std_lst, scholarship_students std_schlr)
        {
            foreach (Student student in std_lst)
            {
                if (std_schlr(student)) 
                {
                    Console.WriteLine("{0} granted scholarship",student.name);
                }
            }
        }
    }
}
