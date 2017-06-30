using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class ListaCompraVM
    {
        public List<CompraVM> lstCompras {get;set;}

        public ListaCompraVM()
        {
            lstCompras = new List<CompraVM>();
        }
    }
}