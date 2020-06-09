using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio3_MVC_PorllesC.Models
{
    public class ClsProducto
    {
        public bool productoWebCam { set; get; }
        public bool productoDiscoDuro { set; get; }
        public bool productoAudifono { set; get; }
        public bool productoTeclado { set; get; }
        public double subtotal { set; get; }
        public double igv { set; get; }
        public double total { set; get; }
    }
}