using CalculadoraWeb_G1.Connections;
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

        public async Task<IActionResult> Index()
        {
            try
            {
                UserModel model = new UserModel();
                RestConnection rest = new RestConnection("http://localhost:63363");

                WelcomeMessage result = await rest.GetAsync<WelcomeMessage>("calc");
                model.Title = result.Message;

                return View("Welcome", model);
            }
            catch (System.Exception ex)
            {
                this._logger.LogError("Error");
                return BadRequest(ex);
            }
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
        public async Task<IActionResult> Calculate(CalcViewModel model, string lastInput)
        {
            CalculateModelService service = new CalculateModelService();

            if (CalcViewModel.signos == null)
                CalcViewModel.signos = new List<string>();

            if (int.TryParse(lastInput, out int number))
            {
                if (CalcViewModel.rett == null)
                {
                    CalcViewModel.rett = new OperationValueList();
                    CalcViewModel.rett.Value = number;
                }
                if (CalcViewModel.signos != null)
                {
                    if (CalcViewModel.signos.Count > 0)
                    {
                        if (int.TryParse(lastInput, out int number2))
                        {
                            CalcViewModel.rett.Operations.Add(new OperationValueKeyPair(number2, CalcViewModel.signos.FirstOrDefault()));
                            model.Result = await service.CalculateResult(CalcViewModel.rett);                            
                            ClearValues(model.Result);
                        }
                    }
                }
            }
            else
            {
                switch (lastInput)
                {
                    case "=":
                        model.Result = await service.CalculateResult(CalcViewModel.rett);
                        ClearValues(model.Result);
                        break;
                    case "+":
                        CalcViewModel.signos.Add("ADD"); break;                       
                    case "-":
                        CalcViewModel.signos.Add("SUB"); break;
                    case "X":
                        CalcViewModel.signos.Add("MUL"); break;
                    default:
                        throw new Exception("operación inválida.");
                }
            }

            return View("Calc", model);
        }

        private void ClearValues(double value)
        {
            CalcViewModel.signos.Clear();
            CalcViewModel.rett.Operations.Clear();
            CalcViewModel.rett.Value = value;
        }
    }
}
