using PartialClass;
using System;

/*
public class Worker
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

    public string get_details()
    {
        return fname+" " + lname+" is a " + designation;
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        WorkerPartial wpr = new WorkerPartial(); 
        wpr.f_name = "Ram";
        wpr.l_name = "Karki";
        wpr.d_designation = "software engineer";
        Console.WriteLine("Details: " + wpr.get_details());

    }
}