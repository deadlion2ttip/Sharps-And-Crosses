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
            BoardState newGame = new BoardState();
            Console.WriteLine(newGame.space1);

            //newGame.space1 = 'X';

            Console.WriteLine(newGame.space1);

            newGame.printBoard();

            Console.WriteLine("Your turn x, select a spot to mark");

            string play = Console.ReadLine();

            if (play == "3")
            Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }

       
    }
}
