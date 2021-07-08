using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tic Tac Toe Game");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            char userLetter = game.ChooseLetter();
            char computerLetter;
            if (userLetter == 'X' || userLetter == 'x')
                computerLetter = 'O';
            else
                computerLetter = 'X';
            Console.WriteLine("User Letter : " + userLetter + "\t Computer Letter : " + computerLetter);
        }
    }
}
