using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Models;

namespace TestConsole
{
    class Program : Boozer
    {
        static void Main(string[] args)
        {
            Human vas = new Vasya();
            vas.Check();
            vas = new Dimon();
            vas.Check();
            Boozer petr = new Boozer();
            petr.Check();
            petr.ToDrinkVodka();
            petr.ToDrinkVodka();
            petr.ShowAllPoints();


            
            

            Console.ReadKey();
        }
    }

    class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }

        protected void GetInfo(int age, string name)
        {
            if (age <= 0)
            {
                Console.WriteLine("{0} not exist", name);
            }
            else
            {
                Console.WriteLine("{0} exist", name);
            }

        }

        public virtual void Check()
        {

        }
        
        

    }

    class Vasya : Human
    {
        public Vasya()
        {
            Age = 12;
            Name = "Vasya";
        }

        public override void Check()

        {
            GetInfo(Age, Name);
        }

    }

    class Dimon : Human
    {
       public Dimon()
        {
            Age = 0;
            Name = "Dimon";
        }
        public override void Check()
        {
            GetInfo(Age, Name);
        }
    }
    class Boozer : Human
    {
        public int BoozerPoint { get;  set; } 

        public Boozer()
        {
            Age = 26;
            Name = "Petrovich";
        }

        public override void Check()
        {
            GetInfo(Age, Name);
        }
        public void ToDrinkVodka()
        {
            BoozerPoint++;
        }
        public void ShowAllPoints()
        {
            Console.WriteLine("BoozerPoints: {0}", BoozerPoint);
        }
    }
}
