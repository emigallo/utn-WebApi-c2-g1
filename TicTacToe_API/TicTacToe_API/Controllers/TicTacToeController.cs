using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;

namespace TicTacToe_API.Controllers
{
    [ApiController]
    [Route("TicTacToe")]
    public class TicTacToeController : Controller
    {
        private Game _game;
        public TicTacToeController()
        {
           // _game = new Game();            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("startgame")]
        public string StartGame(Player p1, Player p2)
        {
            //_game.StartGame(p1, p2);
            return "Inicio de Juego";
        }

        [HttpGet]
        [Route("move")]
        public string Move(int position, Player player)
        {
            try
            {
                return _game.Move(position, player);
            }
            catch (Exception eX)
            {

                return eX.Message;
            }
            
        }
    
}
