using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DivChat.Models;
using DivChat.Services;

namespace DivChat.Controllers
{
    public class RatesController : Controller
    {
        private IRateService service;
        public RatesController()
        {
            service = new RateService();
        }

        // GET: Rates
        public IActionResult Index()
        {
            return View(service.GetAll());
        }
        public IActionResult List()
        {
            return View(service.GetAll());
        }

        // GET: Rates/Details/5
        public IActionResult Details(int id)
        {
            return View(service.Get(id));
        }

        // GET: Rates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rates/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string name, int stars, string description)
        {
            service.Create(name, stars, description);
            return RedirectToAction(nameof(Index));
        }

        // GET: Rates/Edit/5
        public IActionResult Edit(int id)
        {
            return View(service.Get(id));
        }

        // POST: Rates/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, string name,int stars, string description)
        {
            service.Edit(id, name, stars, description);
            return RedirectToAction(nameof(Index));
        }

        // GET: Rates/Delete/5
        public IActionResult Delete(int id)
        {
            return View(service.Get(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteforReal(int id)
        {
            service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ActionName("Search")]
        public IActionResult Search(string query)
        {
            return View(service.GetRatesByName(query));

        }

    }
}
