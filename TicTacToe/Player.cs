using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public string Name { get; set; }
        public TileState Letter { get; }

        public Player(TileState letter, string name)
        {
            Name = name;
            Letter = letter;
        }

        public Player(TileState letter)
        {
            Letter = letter;
        }
    }
}
