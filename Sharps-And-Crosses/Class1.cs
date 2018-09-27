using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoardState
    {
        public char[] spaces = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public void printBoard()
        {
            Console.WriteLine("{0}|{1}|{2}", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2}", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2}", spaces[6], spaces[7], spaces[8]);
        }

        public char isWinner()
        {
            if((spaces[0] == spaces[1] && spaces[1] == spaces[2]) ||
               (spaces[3] == spaces[4] && spaces[4] == spaces[5]) ||
               (spaces[6] == spaces[7] && spaces[7] == spaces[8]) ||
               (spaces[0] == spaces[3] && spaces[3] == spaces[6]) ||
               (spaces[1] == spaces[4] && spaces[4] == spaces[7]) ||
               (spaces[2] == spaces[5] && spaces[5] == spaces[8]) ||
               (spaces[0] == spaces[4] && spaces[4] == spaces[8]) ||
               (spaces[2] == spaces[4] && spaces[4] == spaces[6]))
            {
                return 'X';
            } else
            {
                return 'N';
            }
            //todo: add lose option 'O' and logic;
        }

        public void markBoard(int move)
        {
            Console.WriteLine(this);
        }
    }

}
