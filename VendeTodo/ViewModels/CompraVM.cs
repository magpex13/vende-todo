using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VendeTodo.Models;

namespace VendeTodo.ViewModels
{
    public class CompraVM
    {
        public int idCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public decimal montoTotal { get; set; }

        public CompraVM()
        {
        }
        public CompraVM(Compra objCompra)
        {
            if (objCompra == null)
                return;
            idCompra = objCompra.CompraID;
            fechaCompra = objCompra.FechaCompra;
            montoTotal = objCompra.MontoTotal;
        }
    }
}