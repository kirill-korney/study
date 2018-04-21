using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Models;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            var cat = new Cat
            {
                Age = 10
            };
            Console.Write("Cat age:{0}", cat.Age);
            Console.ReadKey();
        }
    }
}
