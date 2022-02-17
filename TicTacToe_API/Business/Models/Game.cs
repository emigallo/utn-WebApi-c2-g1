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

        public Game()
        {

        }

        public Player Player_1 { get; set; }
        public Player Player_2 { get; set; }

        public int Turn { get; set; } // revisar nombre de la variable

        public string Move(int position, Player player) // PlayTurn
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

        public bool AskCellBusy()
        {
            return true;
        }

        public bool IsThereAWinner()
        {
            // Gana la jugada en Diagonal
            // Gana la jugada en Vertical
            // Gana la jugada en Horizontal

            return true;
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

        public void StartGame(Player play1, Player play2)
        {
            InitGame();
            
            //Player_1 = new Player(TypePiece.circle, "pepe");
            //Player_2 = new Player(TypePiece.cross, "jose");

            _currentPlayer = play1;
        }

        public void InitGame()
        {
            _boardGame = new Board();
            //_boardGame.FullEmpty();
        }

        public bool EndGane()
        {
            return _boardGame.FullBoard();
        }
    }
}
