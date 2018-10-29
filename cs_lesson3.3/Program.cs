using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch 语句
            const string myName = "karli";
            const string sexyName = "angelina";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me !");
                    break;
                case sexyName:
                    Console.WriteLine("What a sexy name you have !");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name ! ");
                    break;
             }
            Console.WriteLine("Hi {0}", name);
            Console.ReadKey();


        }
    }
}
