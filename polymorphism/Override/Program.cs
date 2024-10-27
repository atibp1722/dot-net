using System;

class Animal
{
    public virtual void display()
    {
        Console.WriteLine("method of animal class");
    }
}
class Dog: Animal
{
    public override void display()
    {
        Console.WriteLine("dog implementation of animal method");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.display();

        Animal anm = new Dog();
        anm.display();  
    }
}