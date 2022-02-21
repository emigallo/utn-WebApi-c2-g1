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
            Player p1 = new Player(Business.Models.TypePiece.cross, "Juan"); // pasan al constructor de gma
            Player p2 = new Player(TypePiece.circle, "Pepe"); // pasan al constructor de gma

            Game g = new Game(p1, p2); // // pasan al constructor de gma

            g.StartGame(p1, p2);
          //  Assert.Pass("Partida iniciado con éxito");

            // Horizontal
            g.Move(0, p1);
            g.Move(3, p2);
            g.Move(1, p1);
            g.Move(4, p2);
            g.Move(2, p1);
        }
    }
}