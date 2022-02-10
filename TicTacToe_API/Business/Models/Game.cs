using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Game
    {
        private static Board _boardGame;
        private static Player _currentPlayer;

        public Game()
        {
            _boardGame = new Board();
            _currentPlayer = _boardGame.Player_1;
        }

        public int Turn { get; set; } // revisar nombre de la variable

        public void Move(int position, Player player)
        {
            // validar si la casilla esta ocupa o no.
            // Si esta libre guardar la posicion
            var result = SetCellBusy(player, position);
        }

        public bool AskCellBusy()
        {
            return true;
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

        public Player GetNextPlayer()
        {
            if (_currentPlayer == _boardGame.Player_1)
            {
                return _boardGame.Player_2;
            }
            else
            {
                return _boardGame.Player_1;
            }
        }

        public bool SetCellBusy(Player player, int numberCell)
        {
            if (_boardGame.Positions[numberCell] == TypePiece.empty)
            {
                _boardGame.Positions[numberCell] = player.TypePlayer;

                if (IsThereAWinner())
                {
                    // hay ganador
                }
                else
                {
                    _currentPlayer = GetNextPlayer();
                    return true;
                }
            }
            else
            {
                // la celda esta ocupada
                return false;
            }
            return true;
        }

        public void StartGane()
        {

        }

        public void ResetGame()
        {
            _boardGame.FullEmpty();
        }

        public void EndGane()
        {

        }
    }
}
