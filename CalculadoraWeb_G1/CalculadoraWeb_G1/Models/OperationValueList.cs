using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.Models
{
    public class OperationValueList
    {
        public OperationValueList()
        {
            this.Operations = new List<OperationValueKeyPair>();
        }

        public double? Value { get; set; }
        public List<OperationValueKeyPair> Operations { get; set; }
    }
}
