using System;

namespace Test
{
    class TicTactoe
    {
        public const int LETTERX = 0;
        public const int LETTERO = 1;
        public static string PLAYER_1;
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void Display()
        {
            Console.WriteLine(" Empty Board Size " + board);
        }

        public static void ChooseLetter()
        {

            Random rand = new Random();
            int letterComputer = rand.Next(0, 2);
            Console.WriteLine(" Choose a Letter");
            int letterPlayer = Convert.ToInt32(Console.ReadLine());

            switch (letterPlayer)
            {
                case LETTERX:
                    Console.WriteLine(" Player choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine("  Player choose O Option  ");
                    break;
            }

            switch (letterComputer)
            {
                case LETTERX:
                    Console.WriteLine(" Computer choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine(" Computer choose O Option  ");
                    break;
            }
        }

        public static void ShowBoard()
        {           
            Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");            
            Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
            Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");
           
        }

        public static void MakeAMove()
        {
            char letter;
            char freeSpace = ' ';
            letter = Console.ReadLine()[0];
            Random rand = new Random();
            int location = rand.Next(1, 10);
            const int index1 = 1;
            const int index2 = 2;
            const int index3 = 3;
            const int index4 = 4;
            const int index5 = 5;
            const int index6 = 6;
            const int index7 = 7;
            const int index8 = 8;
            const int index9 = 9;
            switch (location)
            {
                case index1:
                    if (board[1] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[1] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[1] = letter;
                        }
                    }
                    break;

                case index2:
                    if (board[2] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[2] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[2] = letter;
                        }
                    }
                    break;
                case index3:
                    if (board[3] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[3] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[3] = letter;
                        }
                    }
                    break;
                case index4:
                    if (board[4] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[4] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[4] = letter;
                        }
                    }
                    break;
                case index5:
                    if (board[5] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[5] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[5] = letter;
                        }
                    }
                    break;
                case index6:
                    if (board[6] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[6] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[6] = letter;
                        }
                    }
                    break;
                case index7:
                    if (board[7] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[7] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[7] = letter;
                        }
                    }
                    break;
                case index8:
                    if (board[8] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[8] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[8] = letter;
                        }
                    }
                    break;
                case index9:
                    if (board[9] == freeSpace)
                    {
                        if (letter == 'X')
                        {
                            board[9] = letter;
                        }
                        else if (letter == 'O')
                        {
                            board[9] = letter;
                        }
                    }
                    break;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Tic Tac Toe ");
            TicTactoe.Display();
            TicTactoe.ChooseLetter();
            TicTactoe.MakeAMove();
            TicTactoe.ShowBoard();


        }
    }
}
