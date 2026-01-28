using Mission4_Tic_Tac_Toe;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        Console.WriteLine("Player 1 is X, Player 2 is O.");
        Console.WriteLine("Choose a number 1-9 to place your mark.\n");

        // Create and initialize the game board (2D board to match Support methods)
        char[,] board = new char[3, 3];
        int counter = 1;
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                board[r, c] = (char)('0' + counter);
                counter++;
            }
        }

        char currentPlayer = 'X';
        int movesMade = 0;
        Support support = new Support();

        // Print starting board
        support.printBoard(board);

        while (true)
        {
            int index = GetValidMove(board, currentPlayer);

            // Update the board
            int row = index / 3;
            int col = index % 3;
            board[row, col] = currentPlayer;
            movesMade++;

            // Print updated board
            support.printBoard(board);

            // Check for winner
            char winner = support.checkWinner(board);
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

    static int GetValidMove(char[,] board, char currentPlayer)
    {
        while (true)
        {
            Console.Write($"\nPlayer {currentPlayer}, enter a spot (1-9): ");
            string? input = Console.ReadLine();

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
            int row = index / 3;
            int col = index % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("That spot is already taken. Try again.");
                continue;
            }

            return index;
        }
    }
}