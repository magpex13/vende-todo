using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class UsuarioVM
    {
        public int idUsuario { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int? DNI { get; set; }


    }
}