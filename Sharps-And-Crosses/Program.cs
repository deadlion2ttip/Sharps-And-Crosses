using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static public void promptForMove(BoardState game)
        {
            Console.WriteLine("Your turn x, select a spot to mark");

            var response = Console.ReadLine();

            int move = int.Parse(response);

            game.markBoard(move);
        }

        static void Main(string[] args)
        {
            var newGame = new BoardState();
           
            newGame.printBoard();

            promptForMove(newGame);
           
            if (newGame.isWinner() == 'X')
            Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }

       
    }
}
