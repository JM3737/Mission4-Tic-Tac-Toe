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
            // Code here
        }

        // Method that receives the game board array as input and returns if there is a winner and who it was
        public char checkWinner(char[,] board)
        {
            // Check rows
            for (int r = 0; r < 3; r++)
            {
                if (board[r, 0] != ' ' &&
                    board[r, 0] == board[r, 1] &&
                    board[r, 1] == board[r, 2])
                {
                    return board[r, 0];
                }
            }

            // Check columns
            for (int c = 0; c < 3; c++)
            {
                if (board[0, c] != ' ' &&
                    board[0, c] == board[1, c] &&
                    board[1, c] == board[2, c])
                {
                    return board[0, c];
                }
            }

            // Check main diagonal
            if (board[0, 0] != ' ' &&
                board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            // Check secondary diagonal
            if (board[0, 2] != ' ' &&
                board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }

            // No winner
            return ' ';
        }
    }
}
