using NUnit.Framework;
using Business.Models;

namespace TicTacToe.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartGame()
        {
            
            Game g = new Game();
            Player p1 = new Player(Business.Models.TypePiece.cross, "Juan");
            Player p2 = new Player(TypePiece.circle, "Pepe");
            
            g.StartGame(p1, p2);
          //  Assert.Pass("Partida iniciado con éxito");

            // Horizontal
            g.Move(4, p1);
            g.Move(1, p2);
            g.Move(2, p1);
            g.Move(0, p2);
            g.Move(6, p1);
        }
    }
}