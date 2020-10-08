using MVC_Calculator.Models;

namespace MVC_Calculator.Services
{
    public interface ICalculationService
    {
        CalculatorViewModel Calculate(CalculatorViewModel model);
    }
}