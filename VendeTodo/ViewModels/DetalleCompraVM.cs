using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class DetalleCompraVM
    {
        public CompraVM compra { get; set; }
        public List<ProductoCompraVM> lstProductosCompra { get; set; }

        public DetalleCompraVM()
        {
            compra = new CompraVM();
            lstProductosCompra = new List<ProductoCompraVM>();
        }
        public DetalleCompraVM(CompraVM compra, List<ProductoCompraVM> lstProductosCompra)
        {
            this.compra = compra;
            this.lstProductosCompra = lstProductosCompra;
        }
    }
}