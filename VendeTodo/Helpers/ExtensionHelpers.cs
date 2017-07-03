using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendeTodo.Helpers
{
    public static class ExtensionHelpers
    {
        public static int toInteger(this object obj)
        {
            return Convert.ToInt32(obj);
        }
        public static int getIdUsuario(this HttpSessionStateBase sess)
        {
            return sess[ConstantHelpers.idUsuarioName].toInteger();
        }
        public static void setIdUsuario(this HttpSessionStateBase sess,int? id)
        {
            sess[ConstantHelpers.idUsuarioName] = id;
        }
        public static void setImgUsuario(this HttpSessionStateBase sess, string img)
        {
            sess[ConstantHelpers.imgUsuario] = img;
        }
        public static bool existsImgUsuario(this HttpSessionStateBase sess)
        {
            return sess[ConstantHelpers.imgUsuario] != null ? true : false;
        }
        public static string getNombreUsuario(this HttpSessionStateBase sess)
        {
            return sess[ConstantHelpers.nombreUsuario].ToString();
        }
        public static void setNombreUsuario(this HttpSessionStateBase sess, string nombre)
        {
            sess[ConstantHelpers.nombreUsuario] = nombre;
        }
    }
}
