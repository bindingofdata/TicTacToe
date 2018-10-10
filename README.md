# TicTacToe
This is my solution to the Tic Tac Toe project in The C# Player's Guide 3rd Ed. 

The book's site is here:
http://starboundsoftware.com/books/c-sharp/

Program.cs 
- Gathers data required to start a game, then starts the game.
- Reports the results of the game back to the players.
- TODO: Add a game menu so more than one game can be played in a session.

Game.cs
- Updates the board state based on user input.
- Manages turns.
- Returns game results.
- TODO: Add AI
- TODO: Add AI difficulty levels { easy; normal; hard; impossible }

Board.cs
- Updates its state.
- Returns its state.
- TODO: Allow board to scale to user specified dimensions.

WinChecker.cs
- Checks for win conditions.
- Returns True if there is a winner.

Player.cs
- Holds player info.

TileState.cs
- Enum for X and O tiles.
