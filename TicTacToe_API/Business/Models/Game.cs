using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Game
    {
<<<<<<< HEAD
        private static Board _boardGame;
        private static Player _currentPlayer;

=======
>>>>>>> main
        public Game()
        {

        }

<<<<<<< HEAD

        public Player Player_1 { get; set; }
        public Player Player_2 { get; set; }

        public int Turn { get; set; } // revisar nombre de la variable

        public void Move(int position, Player player) // PlayTurn
        {
            try
            {
                _boardGame.VerifiedPosition(position);
                
                bool result = _boardGame.SetCellBusy(player, position);

                if (result)
                {
                    if (!EndGane())
                    {
                        if (!IsThereAWinner())
                        {
                            _currentPlayer = GetNextPlayer();
                        }
                        else
                        {
                            // MOSTRAR MENSAJE DE QUIEN GANO
                        }
                    }
                    else
                    {
                        // MOSTRAR EL MENSAJE DE EMPATE
                    }
                }
                else
                {
                    // MAL MOVIMIENTO
                    throw new Exception("Celda ocupada.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public bool AskCellBusy() // programar el metodo
=======
        public void Jugada(int position, Player player, TypePiece piece)
        {
            // validar si la casilla esta ocupa o no.
            // Si esta libre guardar la posicion
        }

        public bool AskCellBusy()
>>>>>>> main
        {
            return true;
        }

<<<<<<< HEAD
        public bool IsThereAWinner()
        {
            // Gana la jugada en Diagonal
            // Gana la jugada en Vertical
=======
        // Turno del Jugador
        public int Turn { get; set; } // revisar nombre de la variable



        public bool IsThereAWinner()
        {
            // Gana la jugada en Diagonal

            // Gana la jugada en Vertical

>>>>>>> main
            // Gana la jugada en Horizontal
            // Enpate

            return true;
        }

<<<<<<< HEAD
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

        public void StartGane()
        {
            InitGame();
            _currentPlayer = Player_1;

            Player_1 = new Player(TypePiece.circle, "pepe");
            Player_2 = new Player(TypePiece.cross, "jose");

        }

        public void InitGame()
        {
            _boardGame = new Board();
        }

        public bool EndGane()
        {
            return _boardGame.FullBoard();
=======
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
>>>>>>> main
        }
    }
}
