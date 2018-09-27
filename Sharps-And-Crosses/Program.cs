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
           
            newGame.printBoard();
            

            Console.WriteLine("Your turn x, select a spot to mark");

            var response = Console.ReadLine();

            int move = int.Parse(response);

            newGame.markBoard(move);
            if (newGame.isWinner() == 'X')
            Console.WriteLine("You Win!");
            else
                Console.WriteLine("You Lose!");
        }

       
    }
}
