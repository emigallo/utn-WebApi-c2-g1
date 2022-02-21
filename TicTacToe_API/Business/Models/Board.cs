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
            positions[numberCell] = player.TypePiece;            
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
            for (int i = 0; i < 3; i++)
            {
                if (positions[i] == positions[i + 3] && positions[i + 3] == positions[i + 6] && positions[i] != TypePiece.empty) {
                    return true;
                }
            }
            return false;
        }

        public bool IsLHorizontal()
        {
            for (int i = 0; i < 3; i++)
            {
                int j = 3 * i;
                if (positions[j] == positions[j + 1] && positions[j + 1] == positions[j + 2] && positions[j] != TypePiece.empty)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsLDiagonal()
        {
            if (positions[0] == positions[4] && positions[4] == positions[8] || positions[2] == positions[4] && positions[4] == positions[6] && positions[4] != TypePiece.empty)
            {
                return true;
            }

            return false;
        }
    }
}
