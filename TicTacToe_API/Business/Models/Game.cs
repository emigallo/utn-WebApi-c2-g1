using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Game
    {
        private static Board boardGame;
        private static Player playerGame;

        public Game()
        {
            boardGame = new Board();
        }
        // Turno del Jugador
        public int Turn { get; set; } // revisar nombre de la variable

        public void Jugada(int position, Player player, TypePiece piece)
        {
            // validar si la casilla esta ocupa o no.
            // Si esta libre guardar la posicion
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
            if (playerGame == boardGame.Player_1)
            {
                return boardGame.Player_2;
            }
            else
            {
                return boardGame.Player_1;
            }
        }

        // Marca la celda del tablero como ocupada.
        public void SetCellBusy(Player player, int numeroCelda, TypePiece ficha)
        {
            if (boardGame.Positions[numeroCelda] == TypePiece.empty)
            {
                boardGame.Positions[numeroCelda] = player.TypePlayer;

                if (IsThereAWinner())
                {
                    // hay ganador
                }
                else
                {
                    player = GetNextPlayer();
                }
            }
        }

        public void StartGane()
        {

        }

        public void EndGane()
        {

        }
    }
}
