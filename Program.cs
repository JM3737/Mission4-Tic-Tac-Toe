using Mission4_Tic_Tac_Toe;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        Console.WriteLine("Player 1 is X, Player 2 is O.");
        Console.WriteLine("Choose a number 1-9 to place your mark.\n");

        // Create and initialize the game board
        char[] board = new char[9];
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (char)('1' + i);
        }

        char currentPlayer = 'X';
        int movesMade = 0;

        // Print starting board
        Support.printBoard(board);

        while (true)
        {
            int index = GetValidMove(board, currentPlayer);

            // Update board
            board[index] = currentPlayer;
            movesMade++;

            // Print updated board
            Support.printBoard(board);

            // Check for winner
            char winner = Support.checkWinner(board);
            if (winner == 'X' || winner == 'O')
            {
                string playerName = (winner == 'X') ? "Player 1 (X)" : "Player 2 (O)";
                Console.WriteLine($"\n{playerName} wins!");
                break;
            }

            // Check for tie
            if (movesMade == 9)
            {
                Console.WriteLine("\nIt's a tie!");
                break;
            }

            // Switch players
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        Console.WriteLine("\nThanks for playing!");
    }

    static int GetValidMove(char[] board, char currentPlayer)
    {
        while (true)
        {
            Console.Write($"\nPlayer {currentPlayer}, enter a spot (1-9): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int spot))
            {
                Console.WriteLine("Invalid input. Enter a number from 1 to 9.");
                continue;
            }

            if (spot < 1 || spot > 9)
            {
                Console.WriteLine("That number is out of range. Choose 1-9.");
                continue;
            }

            int index = spot - 1;

            if (board[index] == 'X' || board[index] == 'O')
            {
                Console.WriteLine("That spot is already taken. Try again.");
                continue;
            }

            return index;
        }
    }
}