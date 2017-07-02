using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendeTodo.ViewModels;
using VendeTodo.Helpers;

namespace VendeTodo.Controllers
{
    public class DetalleCuentaController : BaseController
    {
        // GET: DetalleCuenta
        public ActionResult Cuentas()
        {
            ListDetalleCuentaVM lstDetalleCuentas = new ListDetalleCuentaVM();
            int usuarioid = Session.getIdUsuario();
            lstDetalleCuentas.lstDetalleCuentas = context.DetalleCuenta.Where(x => x.CuentaID == usuarioid).Select(x=>new DetalleCuentaVM()
            {
                idDetalleCuenta = x.DetallaCuentaID,
                tasaInteresMora = x.TasaInteres1.Interes,
                fechaInicial = x.FechaInicio,
                fechaFinal = x.FechaFinal,
                estado = x.EstadoDetalleCuenta.Nombre
            }).ToList();
            return View(lstDetalleCuentas);
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
