using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class ListaCompraVM
    {
        public decimal? pagoInicial { get; set; }
        public List<CompraVM> lstCompras {get;set;}

        public List<PagosVM> lstPagos { get; set; }

        public ListaCompraVM()
        {
            lstCompras = new List<CompraVM>();
            lstPagos = new List<PagosVM>();
        }
    }
}