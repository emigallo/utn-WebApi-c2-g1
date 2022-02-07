using CalculadoraWeb_G1.Connections;
using CalculadoraWeb_G1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.Services
{
    public class CalculateModelService
    {
        public CalculateModelService()
        {
        }

        public async Task<double> CalculateResult(OperationValueList operationValueList)
        {
            // baseUri: http://localhost:5500
            // partialUri: calc

            RestConnection rest = new RestConnection("http://localhost:63363");
            string result = await rest.PostAsync<string, OperationValueList>("calc/history", operationValueList);

            return Convert.ToDouble(result);
        }
    }
}
