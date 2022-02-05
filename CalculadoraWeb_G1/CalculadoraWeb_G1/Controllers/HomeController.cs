using CalculadoraWeb_G1.Models;
using CalculadoraWeb_G1.Services;
using CalculadoraWeb_G1.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Welcome");
        }

        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Calc");
            }

            ViewBag.Error = "Hay campos sin completar";
            return View("Welcome", model);
        }

        [HttpGet]
        [Route("Calc")]
        public IActionResult Calc()
        {
            CalcViewModel model = new CalcViewModel();
            return View(model);
        }

        [HttpPost]
        [Route("Calc")]
        public IActionResult Calculate(CalcViewModel model, string lastInput)
        {
            CalculateModelService service = new CalculateModelService();

            if (lastInput == "=")
            {
                model.Result = service.CalculateResult();
            }

            if (lastInput == "+")
            {

            }

            int number;
            if (int.TryParse(lastInput, out number))
            {

            }

            return View("Calc", model);
        }
    }
}
