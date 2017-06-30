using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class ListDetalleCuentaVM
    {
        public List<DetalleCuentaVM> lstDetalleCuentas { get; set; }

        public ListDetalleCuentaVM() 
        {
            lstDetalleCuentas = new List<DetalleCuentaVM>();
        }
    }
}
