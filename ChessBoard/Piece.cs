using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumMoviments { get; protected set; }
        public Board BoardPosition { get; protected set; }

        public Piece(Board boardPosition, Color color)
        {
            Position = null;
            BoardPosition = boardPosition;
            Color = color;
            NumMoviments = 0;
        }
    }
}
