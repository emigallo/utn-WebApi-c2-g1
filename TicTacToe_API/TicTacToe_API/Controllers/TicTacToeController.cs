using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe_API.Controllers
{
    public class TicTacToeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
