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
            // TODO: Instantiate your players
            Player player1 = new Player();
            Player player2 = new Player();

            // Create the Game
            Game game = new Game(player1, player2);

            // Play the Game
            Player winner = game.Play();

            // Output the winner
            Console.WriteLine($"The winner is {winner}!");
        }
    }
}
