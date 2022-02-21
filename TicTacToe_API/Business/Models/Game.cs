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

        public Game(Player player1, Player player2)
        {
            Player_1 = player1;
            Player_2 = player2;
        }

        public Player Player_1 { get; set; } // cambiar a init
        public Player Player_2 { get; set; } // cambiar a init

        public int Turn { get; set; } // revisar nombre de la variable

        public string Move(int position, Player player)
        {           
            _boardGame.ValidatePosition(position);                 
            _boardGame.SetCellBusy(player, position);
             
            if (!EndGane())
            {
                if (!IsThereAWinner())
                {
                    _currentPlayer = GetNextPlayer();
                }
                else
                {
                    return _currentPlayer.Name + "Ha ganado el juego";
                }
            }
            else
            {
                return "Nadie ha ganado";
            }

            return "Mueve" + _currentPlayer.Name;
            
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

        public void StartGame(Player player1, Player player2) // borrar metdo
        {

            InitGame();

            //SetupPlayers(player1, player2);

            _currentPlayer = player1;
        }

        public void InitGame() // borrar metdo
        {
            _boardGame = new Board();
            //_boardGame.FullEmpty();
        }

        public bool EndGane()
        {
            return _boardGame.FullBoard();
        }




        private void SetupPlayers(Player player1, Player player2)
        {
            if (player1.TypePiece == TypePiece.empty ||
                player2.TypePiece == TypePiece.empty ||
                player1.TypePiece == player2.TypePiece)
            {
                player1.TypePiece = TypePiece.circle;
                player2.TypePiece = TypePiece.cross;
            }
        }
    }
}
