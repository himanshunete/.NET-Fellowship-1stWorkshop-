using System;

namespace Test
{
    class TicTactoe
    {
        public static string PLAYER_1;
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void Display()
        {
            
            Console.WriteLine(" Empty Board: " + board);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Tic Tac Toe ");
            TicTactoe.Display();

        }
    }
}
