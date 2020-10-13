using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using October12Exercise.Models;

namespace October12Exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContext;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContext)
        {
            _logger = logger;
            _httpContext = httpContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ChangeUI(UISettingModel model)
        {
            _httpContext.HttpContext.Session.SetString("font", model.Font);
            _httpContext.HttpContext.Session.SetString("backgroundColor", model.BackgroundColor);

            ViewData["font"] = model.Font;
            ViewData["backgroundColor"] = model.BackgroundColor;

            ViewBag.Font = model.Font;
            ViewBag.BackgroundColor = model.BackgroundColor;

            return View(model);
        }
    }
}
