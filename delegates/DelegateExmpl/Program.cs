using DelegateExmpl;
using System;

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student()
        {
            roll = 10,
            name = "Ram Karki",
            age = 25,
            year = 2020,
            subject = "CSE"
        };
        Student std1 = new Student()
        {
            roll = 4,
            name = "Geeta Sharma",
            age = 19,
            year = 2023,
            subject = "Econ"
        };
        Student std2 = new Student()
        {
            roll = 13,
            name = "Shyam Sundar",
            age = 30,
            year = 2019,
            subject = "CSE"
        };
        Student std3 = new Student()
        {
            roll = 20,
            name = "Yagya KC",
            age = 24,
            year = 2021,
            subject = "Accn"
        };

        List<Student> std_lst = new List<Student>();
        std_lst.Add(std);
        std_lst.Add(std1);
        std_lst.Add(std2);
        std_lst.Add(std3);

        scholarship_students sstd = new scholarship_students(Program.Eligible);
        Student.scholarship_student(std_lst, sstd);
    }

    public static bool Eligible(Student student) 
    {
        if (student.year > 2020)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}