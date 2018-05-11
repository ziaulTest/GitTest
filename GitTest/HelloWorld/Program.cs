using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name?\n");
            string s = Console.ReadLine();
            Console.WriteLine(s+", hello :)");
            // added a comment here to check it works :)
        
            Console.ReadKey();
        }
    }
}
