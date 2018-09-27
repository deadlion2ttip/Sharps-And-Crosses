using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoardState
    {
        public char space1 = '1';
        public char space2 = '2';
        public char space3 = '3';
        public char space4 = '4';
        public char space5 = '5';
        public char space6 = '6';
        public char space7 = '7';
        public char space8 = '8';
        public char space9 = '9';


        public void printBoard()
        {
            Console.WriteLine("{0}|{1}|{2}", space1, space2, space3);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2}", space4, space5, space6);
            Console.WriteLine(@"-----");
            Console.WriteLine("{0}|{1}|{2}", space7, space8, space9);
        }
    }

}
