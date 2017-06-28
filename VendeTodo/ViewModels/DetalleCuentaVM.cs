using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class DetalleCuentaVM
    {
        public int idCuenta { get; set; }
        public int tasaInteres { get; set; }
        public int tasaInteresCompen { get; set; }
        public int tasaInteresMora { get; set; }
        public double prestamo { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }

    }
}