using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] board;
        public char[] CreateBoard()
        {
            board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;

        }
        public char ChooseLetter()
        {
            while (true)
            {
                Console.Write("Choose a Letter among 'X' or 'O' : ");
                char letter = Convert.ToChar(Console.ReadLine());
                if (letter == 'X' || letter == 'O' || letter == 'x' || letter == 'o')
                {
                    return letter;
                }
                else
                {
                    Console.WriteLine(" Try Again - Invalid Input");
                }
            }
        }
    }
}
