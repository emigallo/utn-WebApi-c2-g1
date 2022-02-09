using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Player
    {
        public Player(TypePiece typePlayer)
        {
            TypePlayer = typePlayer;
        }

        public TypePiece TypePlayer { get; set; }

    }
}
