using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Player
    {
        public Player(TypePiece typePlayer, string name)
        {
            TypePlayer = typePlayer;
            Name = name;
        }

        public string Name { get; set; }
        public TypePiece TypePlayer { get; set; }

    }
}
