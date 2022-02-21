using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Player
    {
        public Player()
        {

        }

        public Player(TypePiece typePiece, string name)
        {
            TypePiece = typePiece;
            Name = name;
        }

        public string Name { get; set; }

        public Player(TypePiece typePiece)
        {
            TypePiece = typePiece;
        }

        public TypePiece TypePiece { get; set; }

    }
}
