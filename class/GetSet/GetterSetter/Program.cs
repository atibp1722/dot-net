using System;

class Player
{
    private int num;
    private string name;
    private int careerGoals = 849;

    public void SetNum(int num)
    {
        if (num < 0)
        {
            throw new Exception("Negative entry not allowed");
        }
        this.num = num;
    }

    public int GetNum()
    {
        return this.num;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Null name not allowed");
        }
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetCareerGoals()
    {
        return this.careerGoals;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Player play=new Player();

        //negative values abruptly terminates the program
        //play.SetNum(-1);
        //play.SetName(null);

        play.SetNum(10);
        play.SetName("Lionel Messi");

        Console.WriteLine("Player number: {0}",play.GetNum());
        Console.WriteLine("Player name: {0}", play.GetName());
        Console.WriteLine("Total career goals: {0}", play.GetCareerGoals());
    }
}