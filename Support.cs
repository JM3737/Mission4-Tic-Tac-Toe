using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4_Tic_Tac_Toe
{
    internal class Support
    {
        // Method that prints the board based on the information passed to it
        public void printBoard(char[,] board)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {board[i, 0]} | {board[i, 1]} | {board[i, 2]} ");
                if (i <2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
            Console.WriteLine();
        }

        // Method that receives the game board array as input and returns if there is a winner and who it was
        public char checkWinner(char[,] board)
        {
            // Code here
        }
    }
}
