using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Calculator.Models
{
    public class CalculatorViewModel
    {
        public decimal InputOne { get; set; }

        public decimal InputTwo { get; set; }

        public CalculatorType Operation { get; set; }

        public string Result { get; set; }
    }
}
