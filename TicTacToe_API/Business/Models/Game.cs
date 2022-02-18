using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
namespace Business.Models
{
    public class Game
    {

        private static Board _boardGame;
        private static Player _currentPlayer;
        private static Player _lastPlayer;

        public Game(string player1name, string player2name)
        {
            
            Player_1 = new Player(TypePiece.cross, player1name);
            Player_2 = new Player(TypePiece.circle, player2name);
            _boardGame = new Board();
            _currentPlayer = Player_1;
            _lastPlayer = null;

        }

        public Player Player_1 { get; init; }
        public Player Player_2 { get; init; }

        public int Turn { get; set; } // revisar nombre de la variable

        public void CheckPlayerMove()
        {
            if(_lastPlayer == _currentPlayer)
            {
                throw new Exception($"No se puede realizar 2 movimientos seguidos.");
            }
        }

        public string Move(int position, Player player) // PlayTurn
        {
            CheckPlayerMove();
            _boardGame.ValidatePosition(position);                 
            _boardGame.SetCellBusy(player, position);
             
            if (!EndGane())
            {
                if (IsThereAWinner())
                {
                   return _currentPlayer.Name + " Ha ganado el juego";
                }
            }
            else
            {
                return "Nadie ha ganado";
            }

            _lastPlayer = player;
            return "Mueve siguiente jugador";            
        }

        public bool AskCellBusy()
        {
            return true;
        }

        public bool IsThereAWinner()
        {
            if ( _boardGame.IsLDiagonal() || _boardGame.IsLHorizontal() || _boardGame.IsVertical())
            {
                return true;
            }
            return false;
        }

        public Player GetNextPlayer()
        {
            if (_currentPlayer == Player_1)
            {
                return Player_2;
            }
            else
            {
                return Player_1;
            }
        }

        public bool EndGane()
        {
            return _boardGame.FullBoard();
        }
    }
}
