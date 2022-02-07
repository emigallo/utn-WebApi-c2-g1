using CalculadoraWeb_G1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.ViewModels.Home
{
    public  class CalcViewModel
    {
        public CalcViewModel()
        {
            this.Rows = new List<List<string>>();

            this.Rows.Add(new List<string>() { "7", "8", "9", "X" });
            this.Rows.Add(new List<string>() { "4", "5", "6", "-" });
            this.Rows.Add(new List<string>() { "1", "2", "3", "+" });
            this.Rows.Add(new List<string>() { "0", null, ",", "=" });

            Rett = new OperationValueList();
        }

        public List<List<string>> Rows { get; set; }
        public double Result { get; set; }
        //public static List<string> signos;
        //public static OperationValueList rett;
        public OperationValueList Rett { get; set; }
    }
}
