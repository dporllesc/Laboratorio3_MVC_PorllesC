using Laboratorio3_MVC_PorllesC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio3_MVC_PorllesC.Controllers
{
    public class ProductoController : Controller
    {
        public static double precioWebCam = 50; double precioDiscoDuro = 250;
        public static double precioAudifono = 35; double precioTeclado = 65;


        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RealizarVenta(ClsProducto objProducto)
        {
            if(objProducto.productoWebCam == true)
            {
                objProducto.subtotal = objProducto.subtotal + precioWebCam;
            }
            if (objProducto.productoDiscoDuro == true)
            {
                objProducto.subtotal = objProducto.subtotal + precioDiscoDuro;
            }
            if (objProducto.productoAudifono == true)
            {
                objProducto.subtotal = objProducto.subtotal + precioAudifono;
            }
            if (objProducto.productoTeclado == true)
            {
                objProducto.subtotal = objProducto.subtotal + precioTeclado;
            }

            objProducto.igv = objProducto.subtotal * 0.19;
            objProducto.total = objProducto.subtotal + objProducto.igv;
            return View(objProducto);
        }
    }
}