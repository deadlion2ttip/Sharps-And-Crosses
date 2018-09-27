using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"1|2|3");
            Console.WriteLine(@"-----");
            Console.WriteLine(@"4|x|o");
            Console.WriteLine(@"-----");
            Console.WriteLine(@"x|8|o");

            Console.WriteLine("Your turn x, select a spot to mark");

            string play = Console.ReadLine();

            if (play == "3")
            Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }
    }
}
