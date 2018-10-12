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
            // TODO: Add a game menu to allow playing more than one game in a row

            string player1 = "";
            string player2 = "";
            int winner = 0;
            Game game;


            while (MainMenu())
            {
                Console.WriteLine("New Game: ");
                Console.WriteLine("Please provide player names: ");
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

            Console.Clear();
            Console.WriteLine("Thanks for playing!");
        }

        static bool MainMenu()
        {
            bool playGame = false;
            bool validSelection = false;

            while (!validSelection)
            {
                Console.WriteLine("TicTacToe!\n");
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. New Game [N/n]");
                Console.WriteLine("2. Exit [E/e]");
                Console.Write("Enter selection -> ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "N":
                    case "n":
                    case "1":
                        playGame = true;
                        validSelection = true;
                        break;
                    case "E":
                    case "e":
                    case "2":
                        validSelection = true;
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }

            return playGame;
        }// MainMenu
        
    }
}
