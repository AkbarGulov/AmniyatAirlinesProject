using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmniyatAirlines.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmniyatAirlines.Controllers
{
    public class AirplanesController : Controller
    {
        public AirplanesController(DBContext db)
        {
            dbContext = db;
        }
        private DBContext dbContext;
        // GET: Airplanes
        public ActionResult Index()
        {
            List<Airplane> airplanes = dbContext.Airplanes.ToList();
            
            return View(airplanes);
        }

        // GET: Airplanes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Airplanes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Airplanes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Airplanes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Airplanes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Airplanes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Airplanes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}