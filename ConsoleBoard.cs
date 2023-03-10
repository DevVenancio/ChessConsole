using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoard;

namespace ChessConsole
{
    class ConsoleBoard
    {
        public static void ShowBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for (int j = 0; j < board.Columns; j++){
                    if (board.PiecePosition(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.PiecePosition(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
