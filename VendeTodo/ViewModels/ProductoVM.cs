using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VendeTodo.Models;

namespace VendeTodo.ViewModels
{
    public class ProductoVM
    {
        public string nombre { get; set; }
        public ProductoVM()
        {
        }
        public ProductoVM(Producto objProducto)
        {
            nombre = objProducto.Nombre;
        }
    }
}
