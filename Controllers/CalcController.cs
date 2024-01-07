using _932020.Rybatsky.Kirill.lab11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;

namespace MvcApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult ViewDataCalc()
        {
            ViewData["CalcData"] = new CalcData();
            return View();
        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.CalcData = new CalcData();
            return View();
        }

        public IActionResult ModelCalc()
        {
            return View(new CalcData());
        }

        public IActionResult ServiceCalc()
        {
            return View();
        }
    }
}