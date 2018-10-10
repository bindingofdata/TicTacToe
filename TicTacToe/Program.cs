using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Board board = new Board();
            Player player1 = new Player(TileState.X, "Bob");
            Player player2 = new Player(TileState.O, "Bobette");
            //Renderer.DrawScreen(player1, player2, board);
            Console.WriteLine(board.ToString());

            Console.ReadKey();

            board.SetTile(0, 0, TileState.X);
            board.SetTile(1, 1, TileState.X);
            board.SetTile(2, 0, TileState.O);
            board.SetTile(2, 1, TileState.O);
            //Renderer.DrawScreen(player1, player2, board);
            Console.WriteLine(board.ToString());
            */

            string player1 = "";
            string player2 = "";
            int winner = 0;
            Game game;

            Console.WriteLine("TicTacToe!\n");

            Console.Write("Player 1: ");
            player1 = Console.ReadLine();

            Console.Write("Player 2: ");
            player2 = Console.ReadLine();

            Console.Clear();

            game = new Game(player1, player2);

            winner = game.NewGame();

            Console.WriteLine();
            if (winner == 1)
                Console.WriteLine($"Congratulations {player1}! You won!");
            else if (winner == 2)
                Console.WriteLine($"Congratulations {player1}! You won!");
            else
                Console.WriteLine("Tie Game!");



            Console.ReadKey();
        }
    }
}
