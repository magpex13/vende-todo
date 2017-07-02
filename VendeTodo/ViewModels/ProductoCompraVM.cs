using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VendeTodo.Models;

namespace VendeTodo.ViewModels
{
    public class ProductoCompraVM
    {
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario {get;set;}
        public decimal? descuento { get; set; }

    }
}