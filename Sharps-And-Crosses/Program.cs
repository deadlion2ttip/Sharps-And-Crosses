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

        static void Main()
        {
            var newGame = new BoardState();

            Console.WriteLine("Welcome to Sharps and Crosses! You get to be X \n");

            newGame.printBoard();

            while (!newGame.isWinner())
            {
                promptForMove(newGame);

                if (!newGame.isWinner())
                {
                    newGame.opponentMove();
                } else
                {
                    newGame.setWinner('X');
                }
            }
            
            if (newGame.winner == 'X')
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }

            Console.WriteLine("Would you like to play again? (y/n)");
            
            string again = Console.ReadLine();

            if (again == "y" || again == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("\nGoodbye!");
            }
            
        }

       
    }
}
