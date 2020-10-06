using MVC_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Calculator.Services
{
    public class CalculationService
    {
        public CalculatorViewModel Calculate(CalculatorViewModel model)
        {
            switch(model.Operation)
            {
                case CalculatorType.Add:
                    model.Result = (model.InputOne + model.InputTwo).ToString();
                    break;

                case CalculatorType.Subtract:
                    model.Result = (model.InputOne - model.InputTwo).ToString();
                    break;

                case CalculatorType.Multiply:
                    model.Result = (model.InputOne * model.InputTwo).ToString();
                    break;

                case CalculatorType.Divide:
                    model.Result = (model.InputOne / model.InputTwo).ToString();
                    break;
            }
            return model;
        }
    }
}
