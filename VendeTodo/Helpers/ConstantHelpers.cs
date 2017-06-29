using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.Helpers
{
    public static class ConstantHelpers
    {
        public static class Login
        {
            public static string controllerName = "Login";
            public static string loginViewName = "Login";
        }
        public static class DetalleCuenta
        {
            public static string controllerName = "DetalleCuenta";
            public static string cuentaViewName = "Cuenta";
            public static List<string> columNamesCuentaView = new List<string>()
            {
                "Cuenta ID",
                "Tasa Interés",
                "Préstamo",
                "Fecha del Préstamo",
                "Fecha Final"
            };
        }

        public static string idUsuarioName = "idUsuario";
    }
}