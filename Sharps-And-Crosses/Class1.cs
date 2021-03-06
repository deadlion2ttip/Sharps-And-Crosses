﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoardState
    {
        private char[] spaces = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char winner = 'N';

        public void setWinner(char w)
        {
            this.winner = w;
        }

        public void printBoard()
        {
            Console.WriteLine("{0}|{1}|{2}", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2}", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2} \n", spaces[6], spaces[7], spaces[8]);
        }

        public bool isWinner()
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
                return true;
            } else
            {
                return false;
            }
           
        }

        public void opponentMove()
        {
            Console.WriteLine("My turn!");
            Random rnd = new Random();
            bool moveMade = false;

            while (!moveMade)
            {
                int move = rnd.Next(1, 10);
                move--;
                if (spaces[move] != 'X' && spaces[move] != 'O')
                {
                    spaces[move] = 'O';
                    moveMade = true;
                }
            }
            printBoard();
            if (isWinner())
            {
                setWinner('O');
            }
        }
        public void markBoard(int move)
        {
            move--;
            if (spaces[move] != 'X' && spaces[move] != 'O')
            {
                spaces[move] = 'X';
                printBoard();
            }
            else
            {
                Console.WriteLine("Please choose an unclaimed space");
                Program.promptForMove(this);
            }

            if (isWinner())
            {
                setWinner('X');
            }
        }
    }

}
