using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Laboratorio3_MVC_PorllesC.Models;

namespace Laboratorio3_MVC_PorllesC.Controllers
{
    public class ParImparController : Controller
    {
        // GET: ParImpar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar(ClsParImpar objParImpar)
        {


            return View(objParImpar);
        }
    }
}