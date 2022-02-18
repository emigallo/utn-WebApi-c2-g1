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
            resultado = g.Move(1, g.Player_2);
            resultado = g.Move(2, g.Player_1);
            resultado = g.Move(0, g.Player_2);
            resultado = g.Move(6, g.Player_1);
            //Assert.Pass("Partida iniciado con éxito");
            Assert.IsFalse(resultado == "Pepe Ha ganado el juego");
            Assert.IsTrue(resultado == "Juan Ha ganado el juego");
            Assert.IsFalse(resultado == "Nadie ha ganado");
            Assert.IsFalse(resultado == "Mueve siguiente jugador");
            //validar jugador 1
            // ir por las otras alternativas
        }
    }
}