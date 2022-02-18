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
            string resultado;
            Game g = new Game("Juan", "Pepe");
         
            // Horizontal
            resultado = g.Move(4, g.Player_1);
            resultado = g.Move(1, g.Player_1);
            resultado = g.Move(2, g.Player_2);
            resultado = g.Move(0, g.Player_1);
            resultado = g.Move(6, g.Player_2);
            //Assert.Pass("Partida iniciado con éxito");
            Assert.IsTrue(resultado == "Pepe Ha ganado el juego");
            //validar jugador 1
            // ir por las otras alternativas
        }
    }
}