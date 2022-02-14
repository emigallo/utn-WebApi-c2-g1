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

        public TypePiece stateCell { get; set; }
        private TypePiece[] Positions { get; init; } 

        public void FullEmpty()
        {
            for (int i = 0; i < 9; i++)
            {
                Positions[i] = TypePiece.empty;               
            }
        }
        
        public void VerifiedPosition(int position) // validar la position no este avcia
        {
            if (position >= 0 && position <= 8)
            {
                throw new Exception("Posicion invalida");
            }

        }

        public bool SetCellBusy(Player player, int numberCell) // 
        {
            if (Positions[numberCell] != TypePiece.empty)
            {
                return false;
            }

            Positions[numberCell] = player.TypePlayer;
            return true;
        }

        public bool FullBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Positions[i] == TypePiece.empty)
                {
                    return false;
                }
            }
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
