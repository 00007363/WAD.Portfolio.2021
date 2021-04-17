using FootballApp.Models;
using FootballApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICouch _couch;

        public HomeController(ICouch couch)
        {
            _couch = couch;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var couches = _couch.GetAll();
            return View(couches);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Couch couch)
        {
            _couch.Create(couch);
            _couch.Save();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var couch = _couch.GetById(Id);
            return View(couch);
        }
        [HttpPost]
        public IActionResult Delete(Couch couch)
        {
            _couch.Remove(couch);
            _couch.Save();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var couch = _couch.GetById(Id);
            return View(couch);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var couch = _couch.GetById(Id);
            return View(couch);
        }
        [HttpPost]
        public IActionResult Edit(Couch couch)
        {
            _couch.Edit(couch);
            _couch.Save();
            return RedirectToAction(nameof(Index));
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
    }
}
