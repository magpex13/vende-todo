using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.ViewModels
{
    public class PagosVM
    {
        public int idpago { get; set; }
        public DateTime fechaPago { get; set; }
        public decimal montoPago { get; set; }
    }
}