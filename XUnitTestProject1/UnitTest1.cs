using System;
using Xunit;
using Lab04_TicTacToe.Classes;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        // Test for winner for new game
        public void TestForWinner()
        {
            Player player1 = new Player();
            player1.Name = "player 1";
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = "player 2";
            player2.Marker = "O";
            Game testGame = new Game(player1, player2);
            Board board = new Board();
            Assert.False(testGame.CheckForWinner(board));
        }

        [Fact]
        // Test for winner when there is a winner 
        public void TestForWinnerWhenThereIsWinner()
        {
            Player player1 = new Player();
            player1.Name = "player 1";
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = "player 2";
            player2.Marker = "O";
            Game testGame = new Game(player1, player2);
            Board board = new Board();
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";
            Assert.True(testGame.CheckForWinner(board));
        }

        [Fact]
        // Test there is a switch in players between turns
        public void ShouldSwitchPlayers()
        {
            Player player1 = new Player();
            player1.Name = "player 1";
            player1.Marker = "X";
            Player player2 = new Player();
            player2.Name = "player 2";
            player2.Marker = "O";
            Game testGame = new Game(player1, player2);
            testGame.SwitchPlayer();
            Assert.True(testGame.PlayerOne.IsTurn);
            Assert.False(testGame.PlayerTwo.IsTurn);
        }
    }
}
