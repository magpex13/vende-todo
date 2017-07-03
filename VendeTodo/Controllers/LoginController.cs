using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendeTodo.ViewModels;
using VendeTodo.Helpers;
using VendeTodo.Models;

namespace VendeTodo.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UsuarioVM usuario)
        {
            Usuario objUsuario = context.Usuario.FirstOrDefault(x => x.DNI == usuario.DNI && x.Password == usuario.password);

            if (objUsuario == null)
            {
                return View();
            }
            Session.setIdUsuario(objUsuario.UsuarioID);
            Session.setImgUsuario(objUsuario.Foto);
            Session.setNombreUsuario(objUsuario.PrimerNombre + " " + objUsuario.ApellidoPaterno);
            return RedirectToAction(ConstantHelpers.DetalleCuenta.cuentaViewName, ConstantHelpers.DetalleCuenta.controllerName);
        }

        public ActionResult Logout()
        {
            Session.setIdUsuario(null);
            Session.setImgUsuario(null);
            Session.setNombreUsuario(null);
            return RedirectToAction(ConstantHelpers.Login.loginViewName, ConstantHelpers.Login.controllerName);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
