using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    public class StrmReader
    {
        public void Main(string[] args)
        {
            string path = @"C:\\Users\\Admin\\Desktop\\test\\text.txt";
            using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
            {
                using StreamReader sr = new StreamReader(fs);
                {
                    foreach(var line in sr.ReadLine())
                    {
                        Console.WriteLine(line);
                    }

                    string lines = "";
                    while ((lines = sr.ReadLine()) != null) 
                    {
                        Console.WriteLine(lines);
                    }

                    string line1 = sr.ReadToEnd();
                    Console.WriteLine(line1);

                    if (sr.Peek() > 0)
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
            }
        }
    }
}
