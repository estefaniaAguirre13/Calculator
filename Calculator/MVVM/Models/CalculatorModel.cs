using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MVVM.Models
{
    public class CalculatorModel
    {
        public string Operation { get; set; }
        public string Result { get; set; } = "0";
    }
}
