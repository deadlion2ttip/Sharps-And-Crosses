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
            var newGame = new BoardState();


            newGame.spaces[1] = 'x';
            newGame.printBoard();
            newGame.markBoard(1);

            Console.WriteLine("Your turn x, select a spot to mark");

            string play = Console.ReadLine();


            if (play == "3")
            Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }

       
    }
}
