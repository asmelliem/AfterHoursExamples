using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Calculator.Models;
using MVC_Calculator.Services;

namespace MVC_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateResult(CalculatorViewModel model)
        {
            var calcService = new CalculationService();
            var result = calcService.Calculate(model);
            //do some work of validating the user input
            //display the results of all the above work
            //display it in the current page?
            //display it in another page?
            //do we need another model?
            //do we need another view? 
            return View(result);
        }
    }
}
