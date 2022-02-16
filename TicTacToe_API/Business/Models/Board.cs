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
            positions = new TypePiece[9];
            
        }

        public TypePiece StateCell { get; set; }
        private TypePiece[] positions { get; set; } 

      
        public void ValidatePosition(int position) 
        {
            if (position < 0 || position > 8)  
            {
                throw new Exception("Posicion invalida");
            }

            if (positions[position] != TypePiece.empty)
            {
                throw new Exception("Celda ocupada");
            }

        }

        public void SetCellBusy(Player player, int numberCell) 
        {
            positions[numberCell] = player.TypePlayer;
            
        }

        public bool FullBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (positions[i] == TypePiece.empty)
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
