using NUnit.Framework;
using Business;

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
            
            Business.Models.Game g = new Business.Models.Game();
            g.StartGame();
            Assert.Pass("Partida iniciado con éxito");
        }
    }
}