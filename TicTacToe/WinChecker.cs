using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class WinChecker
    {
        public static bool CheckForWinner(Board board)
        {
            //test rows
            for (int i = 0; i < 3; i++)
            {
                if (board.CurrentBoard[i, 0] == " ")
                    continue;
                string[] results = new string[3];
                for (int j = 0; j < 3; j++)
                    results[j] = board.CurrentBoard[i, j];
                if (results[0] == results[1] && results[0] == results[2])
                    return true;
            }

            //test columns
            for (int i = 0; i < 3; i++)
            {
                if (board.CurrentBoard[0, i] == " ")
                    continue;
                string[] results = new string[3];
                for (int j = 0; j < 3; j++)
                    results[j] = board.CurrentBoard[j, i];
                if (results[0] == results[1] && results[0] == results[2])
                    return true;
            }

            //test diagonals
            if (board.CurrentBoard[0,0] != " ")
                if (board.CurrentBoard[0, 0] == board.CurrentBoard[1, 1]
                    && board.CurrentBoard[0, 0] == board.CurrentBoard[2, 2])
                    return true;
            if (board.CurrentBoard[2, 0] != " ")
                if (board.CurrentBoard[0, 2] == board.CurrentBoard[1, 1]
                    && board.CurrentBoard[0, 2] == board.CurrentBoard[2, 0])
                    return true;

            return false;
        }
    }
}
