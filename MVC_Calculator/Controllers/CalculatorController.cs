using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Calculator.Models;

namespace MVC_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate()
        {           
           //do some work of validating the user input
           //do some work of actually calculating
           //display the results of all the above work
            //display it in the current page?
            //display it in another page?
            //do we need another model?
            //do we need another view? 
        }
    }
}
