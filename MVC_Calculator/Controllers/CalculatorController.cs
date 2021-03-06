﻿using System;
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

        private readonly ICalculationService _calculationService;

        public CalculatorController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateResult(CalculatorViewModel model)
        {            
            var result = _calculationService.Calculate(model);
            return View(result);
        }
    }
}
