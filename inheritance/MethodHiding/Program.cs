using System;

public class Worker
{
    public int id;
    public string fname;
    public string lname;

    public void FullName()
    {
        Console.WriteLine("Full name: "+fname+" "+lname);
    }
}

public class RemoteWorker: Worker
{
    public new void FullName()
    {
        Console.WriteLine("Full name: " + fname + " " + lname+" works virutally from Nepal");
        //base.FullName();
;    }
}

public class SiteWorker : Worker
{

}

class Program
{
    public static void Main(string[] args)
    {
        RemoteWorker rw = new RemoteWorker();
        rw.id = 100;
        rw.fname = "Ram";
        rw.lname = "Karki";
        rw.FullName();

        SiteWorker sw = new SiteWorker();
        sw.id = 110;
        sw.fname = "Gita";
        sw.lname = "Sharma";
        sw.FullName();
    }
}