using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendeTodo.ViewModels;

namespace VendeTodo.Controllers
{
    public class DetalleCuentaController : Controller
    {
        // GET: DetalleCuenta
        public ActionResult Cuenta()
        {
            DetalleCuentaVM objDetalle = new DetalleCuentaVM();
            return View();
        }

        // GET: DetalleCuenta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DetalleCuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalleCuenta/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetalleCuenta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetalleCuenta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetalleCuenta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetalleCuenta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
