using Events;
using System;

class Program
{
    static void Main(string[] args)
    {
        Db db = new Db();
        Generator generator = new Generator(); 
        Mail mail = new Mail();

        Actions.TestEvent += db.db_save;
        Actions.TestEvent += generator.generate_info;
        Actions.TestEvent += mail.send_mail;

        Console.WriteLine("Enter option [y/n]:");

        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("n"))
                break;
            else if (input.Equals("y"))
            {
                Console.WriteLine("Enter name:");
                var name=Console.ReadLine();

                Console.WriteLine("Enter age:");
                var age = int.Parse(Console.ReadLine());

                Console.WriteLine("Send mail?:");
                var confirm = Console.ReadLine();
                if (confirm.Equals("n")) 
                {
                    Actions.TestEvent -= mail.send_mail;
                }

                Actions.sample_event(age,name);
            }
            else 
            {
                Console.WriteLine("invalid option");
            }
        }
    }
}