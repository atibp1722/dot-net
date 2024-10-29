using System;

interface Person
{
    void show();
}

interface Buyer
{
    void buy();
}

class Customer: Person,Buyer
{
    public void show()
    {
        Console.WriteLine("Person interface called here");
    }
    public void buy()
    {
        Console.WriteLine("Buy interface called here");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer cst = new Customer();
        cst.show();
        cst.buy();
    }
}