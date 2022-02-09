using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Board
    {
        public Board()
        {
            FullEmpty();
        }

        // Posiciones del tablero
        public TypePiece[] Positions { get; init; } // init
        // Alex

        public void FullEmpty()
        {
            for (int i = 0; i < 8; i++)
            {
                Positions[i] = TypePiece.empty;
               
            }
        }
    }
}
