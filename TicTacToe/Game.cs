using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        public Player Player1 { get; }
        public Player Player2 { get; }
        public int CurrentTurnPlayer { get; private set; }
        private int currentTurn;

        public Board board { get; }
        bool isWinner = false;

        public Game(string player1Name, string player2Name)
        {
            Player1 = new Player(TileState.X, player1Name);
            Player2 = new Player(TileState.O, player2Name);

            board = new Board();
        }

        public int NewGame()
        {
            board.ResetBoard();
            isWinner = false;

            CurrentTurnPlayer = 1;
            currentTurn = 0;

            DrawGame();

            return RunGame();
        }

        private int RunGame()
        {
            int winner = 0;

            while (!isWinner)
            {
                if (currentTurn == 9)
                    break;

                UpdateBoard();
                ChangeTurns();
                DrawGame();

                isWinner = WinChecker.CheckForWinner(board);
            }

            if (isWinner)
                winner = CurrentTurnPlayer;

            return winner;
        }

        private void UpdateBoard()
        {
            bool validInput = false;
            bool locationFree = false;
            char[] userSelection;
            int[] tileCoordinates;

            while (!validInput)
            {
                if (CurrentTurnPlayer == 1)
                    Console.WriteLine($"{Player1.Name}'s Turn");
                else
                    Console.WriteLine($"{Player2.Name}'s Turn");

                Console.Write("Enter your move (Letter then Number [eg A1]): ");
                userSelection = Console.ReadLine().ToCharArray();
                if (userSelection.Length > 0)
                    validInput = ValidateInpute(userSelection);

                if (validInput)
                {
                    tileCoordinates = new int[2];

                    switch (userSelection[0])
                    {
                        case 'A':
                        case 'a':
                            userSelection[0] = '0';
                            break;
                        case 'B':
                        case 'b':
                            userSelection[0] = '1';
                            break;
                        case 'C':
                        case 'c':
                            userSelection[0] = '2';
                            break;
                        default:
                            break;
                    }

                    int.TryParse(userSelection[0].ToString(), out tileCoordinates[0]);
                    int.TryParse(userSelection[1].ToString(), out tileCoordinates[1]);

                    locationFree = CheckLocation(tileCoordinates[0], tileCoordinates[1] - 1);

                    if (locationFree)
                        board.SetTile(tileCoordinates[0], tileCoordinates[1] - 1, (TileState)CurrentTurnPlayer);
                    else
                    {
                        validInput = false;
                        Console.Clear();
                        DrawGame();
                        Console.WriteLine("That location is already taken. Please select a different square.");
                    } 
                }
                else
                {
                    Console.Clear();
                    DrawGame();
                    Console.WriteLine("Invalid input. Please enter a Letter followed by a Number [eg A1]");
                }
            } 
        }

        private bool CheckLocation(int x, int y)
        {
            return board.CurrentBoard[y, x] == " ";
        }

        private bool ValidateInpute(char[] userSelection)
        {
            bool inputIsValid = false;
            bool validLetter = false;
            bool validNumber = false;

            switch (userSelection[0])
            {
                case 'A':
                case 'a':
                case 'B':
                case 'b':
                case 'C':
                case 'c':
                    validLetter = true;
                    break;
                default:
                    break;
            }

            if (userSelection.Length > 1)
            {
                switch (userSelection[1])
                {
                    case '1':
                    case '2':
                    case '3':
                        validNumber = true;
                        break;
                    default:
                        break;
                }
            }

            if (validLetter == true && validNumber == true)
                inputIsValid = true;

            return inputIsValid;
        }

        private void ChangeTurns()
        {
            if (CurrentTurnPlayer == 1)
                CurrentTurnPlayer = 2;
            else
                CurrentTurnPlayer = 1;

            currentTurn++;
        }

        private void DrawGame()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"X - {Player1.Name}");
            builder.AppendLine($"O - {Player2.Name}\n\n");
            builder.AppendLine(board.ToString());

            Console.Clear();
            Console.WriteLine(builder);
        }
    }
}
