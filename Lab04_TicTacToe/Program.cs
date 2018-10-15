using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayGame();
		}

		static void PlayGame()
		{
            // DONE: Instantiate your players
            Player player1 = new Player();
            player1.Name = "player 1";
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = "player 2";
            player2.Marker = "O";

            // Create the Game
            Game game = new Game(player1, player2);

            // Play the Game
            Player winner = game.Play();

            // Output the winner
            Console.WriteLine($"The winner is {winner}!");
        }
    }
}
