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
        public Color MyProperty { get; protected set; }
        public int NumMoviments { get; protected set; }
        public Board BoardPosition { get; protected set; }

        public Piece(Position position, Color myProperty)
        {
            Position = position;
            MyProperty = myProperty;
            NumMoviments = 0;
        }
    }
}
