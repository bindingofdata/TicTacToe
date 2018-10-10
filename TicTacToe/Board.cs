using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public string[,] CurrentBoard { get; private set; }

        public Board()
        {
            CurrentBoard = new string[3, 3];
            ResetBoard();
        }

        public void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    CurrentBoard[i, j] = " ";
        }

        public bool SetTile(int x, int y, TileState player)
        {
            bool success = false;
            switch (player)
            {
                case TileState.X:
                    CurrentBoard[y, x] = "X";
                    success = true;
                    break;
                case TileState.O:
                    CurrentBoard[y, x] = "O";
                    success = true;
                    break;
                default:
                    break;
            }

            return success;
        }

        public override string ToString()
        {
            StringBuilder screen = new StringBuilder();

            screen.Clear();
            screen.Append("   A | B | C \n");
            screen.Append($"1  {CurrentBoard[0, 0]} | " +
                $"{CurrentBoard[0, 1]} | {CurrentBoard[0, 2]} \n");
            screen.Append("  ---+---+---\n");
            screen.Append($"2  {CurrentBoard[1, 0]} | " +
                $"{CurrentBoard[1, 1]} | {CurrentBoard[1, 2]} \n");
            screen.Append("  ---+---+---\n");
            screen.Append($"3  {CurrentBoard[2, 0]} | " +
                $"{CurrentBoard[2, 1]} | {CurrentBoard[2, 2]} ");

            return screen.ToString();
        }
    }
}
