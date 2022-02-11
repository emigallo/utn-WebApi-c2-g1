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
            Player_1 = new Player(TypePiece.circle, "pepe");
            Player_2 = new Player(TypePiece.cross, "jose");
        }

        public Player Player_1 { get; set; }
        public Player Player_2 { get; set; }
        public TypePiece stateCell { get; set; }
        public TypePiece[] Positions { get; init; } 

        public void FullEmpty()
        {
            for (int i = 0; i < 8; i++)
            {
                Positions[i] = TypePiece.empty;               
            }
        }

        public bool IsThereAWinner()
        {
            // Gana la jugada en Diagonal
            // Gana la jugada en Vertical
            // Gana la jugada en Horizontal
            // Enpate

            return true;
        }

        public bool IsVertical()
        {
            return true;
        }

        public bool IsLHorizontal()
        {
            return true;
        }

        public bool IsLDiagonal()
        {
            return true;
        }

    }
}
