using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public enum TypePiece
    {
        empty,
        circle,
        cross
    }

    public class TypePieceExtension
    {
        public static string TypePiece2String(TypePiece symbol)
        {
            switch (symbol)
            {
                case TypePiece.empty:
                    return " ";
                case TypePiece.cross:
                    return "X";
                case TypePiece.circle:
                    return "O";
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

