using Api.DTOs;
using Business.Models;
using Business.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("calc")]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {
        }

        [HttpGet]
        public ActionResult Default()
        {
            WelcomeMessage message = new WelcomeMessage();
            message.Message = "Esta es la API de la calculadora " + DateTime.Now.ToString();
            message.Weather = "Sunny";
            return Ok(message);
        }

        [HttpGet]
        [Route("do")]
        public string Do(double value1, string operation, double value2)
        {
            OperationBase op;
            switch (operation)
            {
                case "ADD":
                    op = new AddOperation(value2);
                    break;

                case "SUB":
                    op = new SubtractOperation(value2);
                    break;

                case "MUL":
                    op = new MultiplyOperation(value2);
                    break;

                case "DIV":
                    op = new DivideOperation(value2);
                    break;

                default:
                    throw new Exception("operación inválida.");
            }

            double result = op.CalculateResult(value1);
            return $"El resultado de la cuenta es: {result}";
        }

        //[HttpGet]
        [HttpPost]
        [Route("history")]
        //public string DoHistory(OperationValueList operations)
        public ActionResult DoHistory(OperationValueList operations)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();
            calc.Add(operations.Value);

            foreach (var item in operations.Operations)
            {
                OperationBase add = this.GetOperationById(item.OperationId);
                add.Value = item.Value;
                calc.Add(add);
            }

            double result = calc.Do();
            //return Ok(string.Format("El resultado de la operación es: {0}", result));
            return Ok(result.ToString());
        }

        [HttpGet]
        [Route("getjson")]
        public ActionResult GetJson()
        {
            // 4 + 3 + 5 - 2 = 10
            OperationValueList rett = new OperationValueList();
            rett.Value = 4;
            rett.Operations.Add(new OperationValueKeyPair(3, "ADD"));
            rett.Operations.Add(new OperationValueKeyPair(5, "ADD"));
            rett.Operations.Add(new OperationValueKeyPair(2, "SUB"));

            return Ok(rett);
        }

        [HttpGet]
        [Route("add")]
        public string Add(double value1, double value2)
        {
            OperationBase op = new AddOperation(value2);
            double result = op.CalculateResult(value1);
            return $"El resultado de la operacion {nameof(AddOperation)} es: {result}";
        }

        [HttpGet]
        [Route("sub")]
        public string Sub(double value1, double value2)
        {
            OperationBase op = new SubtractOperation(value2);
            double result = op.CalculateResult(value1);
            return $"El resultado de la operacion {nameof(SubtractOperation)} es: {result}";
        }

        [HttpGet]
        [Route("mul")]
        public string Mul(double value1, double value2)
        {
            OperationBase op = new MultiplyOperation(value2);
            double result = op.CalculateResult(value1);
            return $"El resultado de la operacion {nameof(MultiplyOperation)} es: {result}";
        }

        [HttpGet]
        [Route("div")]
        public string Div(double value1, double value2)
        {
            OperationBase op = new DivideOperation(value2);
            double result = op.CalculateResult(value1);
            return $"El resultado de la operacion {nameof(DivideOperation)} es: {result}";
        }

        private OperationBase GetOperationById(string id)
        {
            switch (id)
            {
                case "ADD":
                    return new AddOperation();

                case "SUB":
                    return new SubtractOperation();

                case "MUL":
                    return new MultiplyOperation();

                case "DIV":
                    return new DivideOperation();

                default:
                    throw new Exception("operación inválida.");
            }
        }
    }
}