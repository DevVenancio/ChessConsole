using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoard;
using ChessPieces;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PlacePieces(new King(board, Color.Black), new Position(0, 0));
            board.PlacePieces(new Queen(board, Color.Black), new Position(0, 1));

            ConsoleBoard.ShowBoard(board);
        }
    }
}
