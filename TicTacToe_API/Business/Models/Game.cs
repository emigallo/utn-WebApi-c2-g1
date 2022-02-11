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
            if (IsVertical() || IsLHorizontal() || IsLDiagonal())
            {
                return true;
            }
            return false;
        }

        public bool IsVertical()
        {
            if (_boardGame.Positions[0] == _boardGame.Positions[3] && _boardGame.Positions[0] == _boardGame.Positions[6])
            {
                return true;
            }
            if (_boardGame.Positions[1] == _boardGame.Positions[4] && _boardGame.Positions[1] == _boardGame.Positions[7])
            {
                return true;
            }
            if (_boardGame.Positions[2] == _boardGame.Positions[5] && _boardGame.Positions[2] == _boardGame.Positions[8])
            {
                return true;
            }
            return false;
        }

        public bool IsLHorizontal()
        {
            if (_boardGame.Positions[0] == _boardGame.Positions[1] && _boardGame.Positions[0] == _boardGame.Positions[2])
            {
                return true;
            }
            if (_boardGame.Positions[3] == _boardGame.Positions[4] && _boardGame.Positions[3] == _boardGame.Positions[5])
            {
                return true;
            }
            if (_boardGame.Positions[6] == _boardGame.Positions[7] && _boardGame.Positions[6] == _boardGame.Positions[8])
            {
                return true;
            }
            return false;
        }

        public bool IsLDiagonal()
        {
            if (_boardGame.Positions[0] == _boardGame.Positions[4] && _boardGame.Positions[0] == _boardGame.Positions[8])
            {
                return true;
            }
            if (_boardGame.Positions[2] == _boardGame.Positions[4] && _boardGame.Positions[2] == _boardGame.Positions[6])
            {
                return true;
            }
            
            return false;
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
