using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Game
    {
        public Game()
        {

        }

        public void Jugada(int position, Player player, TypePiece piece)
        {
            // validar si la casilla esta ocupa o no.
            // Si esta libre guardar la posicion
        }

        public bool AskCellBusy()
        {
            return true;
        }

        // Turno del Jugador
        public int Turn { get; set; } // revisar nombre de la variable



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

        // Le toca jugar al jugador...
        public void GetNextPlayer()
        {

        }

        // Marca la celda del tablero como ocupada.
        public void SetCellBusy(int numeroCelda, TypePiece ficha)
        {
            Positions[numeroCelda] = ficha;
        }
    }
}
