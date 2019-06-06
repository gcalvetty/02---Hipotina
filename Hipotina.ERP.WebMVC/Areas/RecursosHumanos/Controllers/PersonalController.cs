using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hipotina.ERP.WebMVC.Areas.RecursosHumanos.Controllers
{
    public class PersonalController : Controller
    {
        // GET: RecursosHumanos/Personal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult pag_personal()
        {
            return View();
        }
    }
}