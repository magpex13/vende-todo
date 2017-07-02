using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendeTodo.Models;
using VendeTodo.ViewModels;

namespace VendeTodo.Controllers
{
    public class ComprasController : BaseController
    {
        // GET: Compras
        public ActionResult Compras(int detallecuentaid)
        {
            ListaCompraVM compras = new ListaCompraVM();
            compras.lstCompras = context.Compra.Where(x => x.CuentaID == detallecuentaid).Select(x => new CompraVM()
            {
                idCompra = x.CompraID,
                fechaCompra = x.FechaCompra,
                montoTotal = x.MontoTotal
            }).ToList();

            return View(compras);
        }

        public ActionResult DetalleCompra(int compraid)
        {
            CompraVM objCompraVM = new CompraVM(context.Compra.FirstOrDefault(x => x.CompraID == compraid));
            DetalleCompraVM objDetalleCompraVM = new DetalleCompraVM(objCompraVM, context.ProductoCompra.Where(x => x.CompraID == compraid).Select(x => new ProductoCompraVM()
            {
                nombreProducto = x.Producto.Nombre,
                cantidad = x.Cantidad,
                descuento = x.Descuento,
                precioUnitario = x.PrecioUnitario
            }).ToList());
            return View(objDetalleCompraVM);
        }

        // GET: Compras/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Compras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compras/Create
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

        // GET: Compras/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Compras/Edit/5
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

        // GET: Compras/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Compras/Delete/5
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
