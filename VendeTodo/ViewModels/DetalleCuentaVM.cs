using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class DetalleCuentaVM
    {
        public int idCuenta { get; set; }
        public decimal tasaInteresMora { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public string estado { get; set; }
    }
}
